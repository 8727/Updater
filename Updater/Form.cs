using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Script.Serialization;
using System.Xml;

namespace Updater
{
    public partial class Ui : Form
    {
        public static Ui Fr;

        string filePath = string.Empty;

        public static UInt32 loadingTimeOut = 120;

        public bool menuEnable = true;

        public static Hashtable Camera = new Hashtable();

        public Ui()
        {
            Fr = this;
            InitializeComponent();
        }

        void UiLock()
        {
            Fr.menuEnable = false;
            Fr.StartIP.Enabled = false;
            Fr.StopIP.Enabled = false;
            Fr.textBox.Enabled = false;
            Fr.checkBoxFolder.Enabled = false;
            Fr.maxParallelism.Enabled = false;
            Fr.dataGridView.Enabled = false;
        }

        void UiUnLock()
        {
            Fr.menuEnable = true;
            Fr.StartIP.Enabled = true;
            Fr.StopIP.Enabled = true;
            Fr.textBox.Enabled = true;
            Fr.checkBoxFolder.Enabled = true;
            Fr.maxParallelism.Enabled = true;
            Fr.dataGridView.Enabled = true;
        }

        void FactorsAdd(string ip, string name)
        {
            Camera.Add(ip, name);
            Fr.progressBar.PerformStep();
        }

        void SetMaxProgressBar(int max)
        {
            Fr.progressBar.Maximum = max;
        }

        public static void StepProgressBar()
        {
            Fr.progressBar.PerformStep();
        }

        void FullProgressBar()
        {
            Fr.progressBar.Value = Fr.progressBar.Maximum;    
        }

        void AddDataGridView()
        {
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.Width = 25;
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            Fr.dataGridView.Columns.Add(CheckboxColumn);

            Fr.dataGridView.Columns.Add("IP", "IP");
            Fr.dataGridView.Columns[1].Width = 90;
            Fr.dataGridView.Columns[1].ReadOnly = true;
            Fr.dataGridView.Columns.Add("Name", "Name");
            Fr.dataGridView.Columns[2].MinimumWidth = 100;
            Fr.dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Fr.dataGridView.Columns[2].ReadOnly = true;

            ICollection cameraKeys = Ui.Camera.Keys;
            foreach (string ipCameraKey in cameraKeys)
            {
                int rowNumbe = Fr.dataGridView.Rows.Add();

                Fr.dataGridView.Rows[rowNumbe].Cells[0].Value = (Camera[ipCameraKey].ToString() == "IP is unavailable" | Camera[ipCameraKey].ToString() == "Not a Factor") ? false : true;
                Fr.dataGridView.Rows[rowNumbe].Cells[1].Value = ipCameraKey;
                Fr.dataGridView.Rows[rowNumbe].Cells[2].Value = Camera[ipCameraKey];
                Thread.Sleep(100);
            }

            //Fr.dataGridView.Refresh();
        }

        public static void StatusDataGridView(int stroka, string stolb, string status)
        {
            Fr.dataGridView.Rows[stroka].Cells[stolb].Value = status;

            switch (status)
            {
                case "Check...":
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Gray;
                    break;

                case "Loading...":
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Yellow;
                    break;

                case "Install...":
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.LightGreen;
                    break;

                case "Installed":
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Green;
                    break;

                case "Missed":
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.LightGray;
                    break;

                default:
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Red;
                    break;
            }
        }

        void AddFileDataGridView(string name)
        {
            int index = dataGridView.Columns.Count;
            dataGridView.Columns.Add(name, name);
            dataGridView.Columns[index].MinimumWidth = 100;
            dataGridView.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[index].ReadOnly = true;
        }

        void checkBoxFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFolder.Checked)
            {
                Selects.Enabled = false;
                string[] files = Directory.GetFiles(Application.StartupPath, "*.tar.gz", SearchOption.AllDirectories);
                int filesUpdate = files.Count();
                textBox.Text = $"{filesUpdate} files in the update folder.";
            }
            else
            {
                Selects.Enabled = true;
                textBox.Text = "Select the file to update.";
            }

        }

        void Selects_Click(object sender, EventArgs e)
        {
            if (!menuEnable)
            {
                MessageBox.Show("Update in progress.", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog.Filter = "Firmware Files (*.tar.gz) | *.tar.gz";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = openFileDialog.SafeFileName;
                    filePath = openFileDialog.FileName;
                }
            }
        }

        async void Updates_Click(object sender, EventArgs e)
        {
            if (!menuEnable)
            {
                MessageBox.Show("Update in progress.", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            UiLock();
            progressBar.Value = 0;
            if (dataGridView.RowCount != 0)
            {
                if (checkBoxFolder.Checked)
                {
                    string[] files = Directory.GetFiles(Application.StartupPath, "*.tar.gz", SearchOption.AllDirectories);
                    
                    if (files.Count() != 0)
                    {
                        foreach (string file in files)
                        {
                            AddFileDataGridView(file.Substring(file.LastIndexOf('\\') + 1));
                        }

                        progressBar.Maximum = dataGridView.Rows.Count * files.Count();

                        var resource = new SemaphoreSlim(maxParallelism.Value, maxParallelism.Value);

                        var tasks = Enumerable.Range(0, dataGridView.Rows.Count).Select(async row =>
                        {
                            await resource.WaitAsync();
                            try
                            {
                                await UpdateFactor.Files((bool)dataGridView.Rows[row].Cells[0].Value, dataGridView.Rows[row].Cells["IP"].Value.ToString(), files, row);
                            }
                            finally
                            {
                                resource.Release();
                            }
                        });

                        await Task.WhenAll(tasks);

                    }
                    else
                    {
                        MessageBox.Show("No file to update", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UiUnLock();
                        return;
                    }
                }
                else
                {
                    if (filePath != "")
                    {
                        AddFileDataGridView(textBox.Text);
                        progressBar.Maximum = dataGridView.Rows.Count;

                        var resource = new SemaphoreSlim(maxParallelism.Value, maxParallelism.Value);

                        var tasks = Enumerable.Range(0, dataGridView.Rows.Count).Select(async row =>
                        {
                            await resource.WaitAsync();
                            try
                            {
                                await UpdateFactor.SingleFile((bool)dataGridView.Rows[row].Cells[0].Value, dataGridView.Rows[row].Cells["IP"].Value.ToString(), filePath, row);
                            }
                            finally
                            {
                                resource.Release();
                            }
                        });
                        
                        await Task.WhenAll(tasks);

                    }
                    else
                    {
                        MessageBox.Show("No file to update", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UiUnLock();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no complexes to update.", "Complexes to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UiUnLock();
                return;
            }

            progressBar.Value = progressBar.Maximum;

            if(MessageBox.Show("Save the list of updated complexes.", "Complexes to update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string fileName = "Updates result " + DateTime.Now.ToString("dd.MM.yyyy HH.mm");
                FileInfo fil = new FileInfo(Application.StartupPath + "\\" + fileName + ".csv");
                using (StreamWriter sw = fil.AppendText())
                {
                    var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
                    sw.WriteLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                    sw.Close();
                }
                using (StreamWriter sw = fil.AppendText())
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sw.WriteLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                    }
                    sw.Close();
                }
            }

            UiUnLock();
        }

        void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.FileName = "Updates result " + DateTime.Now.ToString("dd.MM.yyyy HH.mm");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fil = new FileInfo(saveFileDialog.FileName);
                using (StreamWriter sw = fil.AppendText())
                {
                    var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
                    sw.WriteLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                    sw.Close();
                }
                using (StreamWriter sw = fil.AppendText())
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sw.WriteLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                    }
                    sw.Close();
                }
            }
        }

        void Search_Click(object sender, EventArgs e)
        {
            if (!menuEnable)
            {
                MessageBox.Show("Update in progress.", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UiLock();

            progressBar.Value = 0;
            dataGridView.Columns.Clear();

            bool startIp = Check(StartIP.Text);
            bool stopIp = Check(StopIP.Text);

            string send = "";
            if (!startIp)
            {
                send = $"Incorrect Start address: {StartIP.Text}";
            }
            if ((!startIp) & (!stopIp))
            {
                send += "\n";
            }
            if (!stopIp)
            {
                send += $"Incorrect Stop address: {StopIP.Text}";
            }
            if ((!startIp) | (!stopIp))
            {
                MessageBox.Show(send, "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Camera.Clear();

            IpSearch(StartIP.Text, StopIP.Text);
        }

        void Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (!menuEnable)
            {
                MessageBox.Show("Update in progress.", "File to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (!Directory.Exists(obj))
                {
                    if(obj.Substring(obj.LastIndexOf('.')) == ".xml")
                    {
                        UiLock();

                        progressBar.Value = 0;
                        dataGridView.Columns.Clear();
                        Camera.Clear();
                        Drop(obj);
                    }
                }
            }
        }


        List<string> computersList = new List<string>();

        public static bool Check(string ip)
        {
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return regex.IsMatch(ip);
        }

        static uint IpToUInt32(string ipAddress)
        {
            return BitConverter.ToUInt32(IPAddress.Parse(ipAddress).GetAddressBytes().Reverse().ToArray(), 0);
        }

        string UInt32ToIp(uint ipAddress)
        {
            return new IPAddress(BitConverter.GetBytes(ipAddress).Reverse().ToArray()).ToString();
        }

        async Task NameComplex(string ip)
        {
            string host = "IP is unavailable";
            PingReply pr = await new Ping().SendPingAsync(ip, 5000);
            if (pr.Status == IPStatus.Success)
            {
                try
                {
                    HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create($"http://{ip}/unitinfo/api/unitinfo");
                    HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                    using (StreamReader stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
                    {
                        string factorJson = stream.ReadToEnd();
                        var datajson = new JavaScriptSerializer().Deserialize<dynamic>(factorJson);
                        string factoryNumber = datajson["unit"]["factoryNumber"];
                        string serialNumber = datajson["certificate"]["serialNumber"];
                        host = serialNumber + " - " + factoryNumber;
                    }
                }
                catch
                {
                    host = "Not a Factor";
                }
            }
            FactorsAdd(ip, host);
        }

        void SearchFactors()
        {
            Task[] tasks = new Task[computersList.Count];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = NameComplex(computersList.ElementAt<string>(i));
            }
            Task.WaitAll(tasks);
            UiUnLock();
            FullProgressBar();
            AddDataGridView();

        }

        public void IpSearch(string Start_IP, string Stop_IP)
        {
            computersList.Clear();
            uint StartIPv4_UInt32 = IpToUInt32(Start_IP);
            uint EndIPv4_UInt32 = IpToUInt32(Stop_IP);

            if (StartIPv4_UInt32 > EndIPv4_UInt32)
            {
                uint xxx = StartIPv4_UInt32;
                StartIPv4_UInt32 = EndIPv4_UInt32;
                EndIPv4_UInt32 = xxx;
            }

            for (uint i = StartIPv4_UInt32; i <= EndIPv4_UInt32; i++)
            {
                computersList.Add(UInt32ToIp(i));
            }

            SetMaxProgressBar(computersList.Count);

            new Thread(() => {
                SearchFactors();
            }).Start();

        }

        void Drop(string file)
        {
            computersList.Clear();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file);
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    if (xnode.Name == "ip")
                    {
                        if (Check(xnode.InnerText))
                        {
                            computersList.Add(xnode.InnerText);
                        }
                    }
                }
            }

            SetMaxProgressBar(computersList.Count);

            new Thread(() => {
                SearchFactors();
            }).Start();
        }
    }
}
