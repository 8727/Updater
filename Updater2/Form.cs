using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Updater2
{
    public partial class Ui : Form
    {
        public static Ui Fr;

        string filePath = string.Empty;

        public static UInt32 loadingTimeOut = 120;

        public bool menuEnable = true;

        public static Hashtable Camera = new Hashtable();

        public class NameVersion
        {
            public string name;
            public string version;
        }

        public Ui()
        {
            Fr = this;
            InitializeComponent();
        }

        public static void UiLock()
        {
            Fr.menuEnable = false;
            Fr.StartIP.Enabled = false;
            Fr.StopIP.Enabled = false;
            Fr.Search.Enabled = false; 
            Fr.sshLogin.Enabled = false;
            Fr.sshPass.Enabled = false;
            Fr.webPort.Enabled = false;
            Fr.sshPort.Enabled = false;
            Fr.checkSaveSettings.Enabled = false;
            Fr.checkBoxFolder.Enabled = false;
            Fr.Selects.Enabled = false;
            Fr.maxParallelism.Enabled = false;
            Fr.dataGridView.Enabled = false;   
        }

        public static void UiUnLock()
        {
            Fr.menuEnable = true;
            Fr.StartIP.Enabled = true;
            Fr.StopIP.Enabled = true;
            Fr.Search.Enabled = true;
            Fr.sshLogin.Enabled = true;
            Fr.sshPass.Enabled = true;
            Fr.webPort.Enabled = true;
            Fr.sshPort.Enabled = true;
            Fr.checkSaveSettings.Enabled = true;
            Fr.checkBoxFolder.Enabled = true;
            Fr.Selects.Enabled = true;
            Fr.maxParallelism.Enabled = true;
            Fr.dataGridView.Enabled = true;
        }

        public static void FactorsAdd(string ip, NameVersion obj)
        {
            Camera.Add(ip, obj);
            Fr.progressBar.PerformStep();
        }

        public static void SetMaxProgressBar(int max)
        {
            Fr.progressBar.Maximum = max;
        }

        public static void StepProgressBar()
        {
            Fr.progressBar.PerformStep();
        }

        public static void FullProgressBar()
        {
            Fr.progressBar.Value = Fr.progressBar.Maximum;    
        }

        public static void AddDataGridView()
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

            Fr.dataGridView.Columns.Add("Version", "Version");
            Fr.dataGridView.Columns[3].MinimumWidth = 80;
            Fr.dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Fr.dataGridView.Columns[3].ReadOnly = true;

            ICollection cameraKeys = Ui.Camera.Keys;
            foreach (string ipCameraKey in cameraKeys)
            {
                NameVersion nameVersion = (NameVersion)Camera[ipCameraKey];

                if (Fr.dataGridView.InvokeRequired)
                {
                    Fr.dataGridView.Invoke((Action)(() => Fr.dataGridView.Rows.Add(new object[] 
                    {
                        (nameVersion.name.ToString() == "IP is unavailable" | nameVersion.name.ToString() == "Not a Factor") ? false : true,
                        ipCameraKey, nameVersion.name, nameVersion.version

                })));
                }
                else
                {
                    Fr.dataGridView.Rows.Add(new object[] 
                    {
                        (nameVersion.name.ToString() == "IP is unavailable" | nameVersion.name.ToString() == "Not a Factor") ? false : true,
                        ipCameraKey, nameVersion.name, nameVersion.version
                    });
                }
            }
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
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Lime;
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
            if (dataGridView.Columns.Contains(name)) return;

            var newCol = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = name,
                MinimumWidth = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            };
            dataGridView.Columns.Add(newCol);
        }

        void checkBoxFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFolder.Checked)
            {
                Selects.Enabled = false;
                string[] patterns = { "*.tar.gz", "*.deb", "*.sh" };
                string[] files = patterns.SelectMany(pattern => Directory.GetFiles(Application.StartupPath, pattern, SearchOption.AllDirectories)).Distinct().ToArray();

                //string[] files = Directory.GetFiles(Application.StartupPath, "*.tar.gz", SearchOption.AllDirectories);
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
                openFileDialog.Filter = "Files (*.tar.gz; *.deb; *.sh) | *.tar.gz; *.deb; *.sh";
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
                    //string[] files = Directory.GetFiles(Application.StartupPath, "*.tar.gz", SearchOption.AllDirectories);
                    string[] patterns = { "*.tar.gz", "*.deb", "*.sh" };
                    string[] files = patterns.SelectMany(pattern => Directory.GetFiles(Application.StartupPath, pattern, SearchOption.AllDirectories)).Distinct().OrderBy(file => Path.GetFileName(file)).ToArray();

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

            progressBar.Value = 0;
            dataGridView.Columns.Clear();

            bool startIp = SearchFactor.Check(StartIP.Text);
            bool stopIp = SearchFactor.Check(StopIP.Text);

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
            UiLock();

            SearchFactor.IpSearch(StartIP.Text, StopIP.Text, webPort.Text);
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
                        SearchFactor.Drop(obj, webPort.Text);
                    }
                }
            }
        }

        private void StartIP_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(StartIP, "Start address for search.");
        }

        private void StopIP_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(StopIP, "Final address to search for.");
        }

        private void Search_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(Search, "Starting a search.");
        }

        private void checkBoxFolder_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(checkBoxFolder, "Update from the program folder or the selected file.");
        }

        private void Selects_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(Selects, "Select a file to update.");
        }

        private void Save_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(Save, "Saving the update table.");
        }

        private void Updates_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(Updates, "Starting the update.");
        }

        private void maxParallelism_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(maxParallelism, "The number of parallel updates is from 1 to 10.");
        }

        private void progressBar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(progressBar, "Progress bar for searching for complexes or performing updates.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkSaveSettings.Checked)
            {
                if (MessageBox.Show("Are you sure you want to disable saving settings during update.", "Saving settings when updating.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    checkSaveSettings.Checked = false;
                }
                else
                {
                    checkSaveSettings.Checked = true;
                }
            }
        }
    }
}
