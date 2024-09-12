using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Updater
{
    public partial class Ui : Form
    {
        public static Ui Fr;

        string filePath = string.Empty;

        public static UInt32 loadingTimeOut = 120;

        public static Hashtable Camera = new Hashtable();

        public Ui()
        {
            Fr = this;
            InitializeComponent();
        }

        public static void UiLock()
        {
            Fr.StartIP.Enabled = false;
            Fr.StopIP.Enabled = false;
            Fr.Search.Enabled = false;
            Fr.Search.BackgroundImage = Properties.Resources.searchL;
            Fr.textBox.Enabled = false;
            Fr.checkBoxFolder.Enabled = false;
            Fr.Selects.Enabled = false;
            Fr.Selects.BackgroundImage = Properties.Resources.selectL;
            //Fr.Save.Enabled = false;
            //Fr.Save.BackgroundImage = Properties.Resources.saveL;
            Fr.Updates.Enabled = false;
            Fr.Updates.BackgroundImage = Properties.Resources.updateL;
            Fr.dataGridView.Enabled = false;
        }

        public static void UiUnLock()
        {
            Fr.StartIP.Enabled = true;
            Fr.StopIP.Enabled = true;
            Fr.Search.Enabled = true;
            Fr.Search.BackgroundImage = Properties.Resources.search;
            Fr.textBox.Enabled = true;
            Fr.checkBoxFolder.Enabled = true;
            Fr.Selects.Enabled = true;
            Fr.Selects.BackgroundImage = Properties.Resources.select;
            //Fr.Save.Enabled = true;
            //Fr.Save.BackgroundImage = Properties.Resources.save;
            Fr.Updates.Enabled = true;
            Fr.Updates.BackgroundImage = Properties.Resources.update;
            Fr.dataGridView.Enabled = true;
        }

        public static void FactorsAdd(string ip, string name)
        {
            Camera.Add(ip, name);
            Fr.progressBar.PerformStep();
        }

        public static void SetMaxProgressBar(int max)
        {
            Fr.progressBar.Maximum = max;
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
            Fr.dataGridView.Columns[2].Width = 100;
            Fr.dataGridView.Columns[2].ReadOnly = true;

            ICollection cameraKeys = Ui.Camera.Keys;
            foreach (string ipCameraKey in cameraKeys)
            {
                int rowNumbe = Fr.dataGridView.Rows.Add();
                Fr.dataGridView.FirstDisplayedScrollingRowIndex = rowNumbe;
                Fr.dataGridView.Rows[rowNumbe].Cells[0].Value = true;
                Fr.dataGridView.Rows[rowNumbe].Cells[1].Value = ipCameraKey;
                Fr.dataGridView.Rows[rowNumbe].Cells[2].Value = Ui.Camera[ipCameraKey];
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
                    Fr.dataGridView.Rows[stroka].Cells[stolb].Style.BackColor = Color.Green;
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
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            foreach (string file in files)
                            {
                                await UpdateFactor.SingleFile(dataGridView.Rows[row.Index].Cells["IP"].Value.ToString(), file, row.Index);
                                progressBar.PerformStep();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("nonnno", "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            await UpdateFactor.SingleFile(dataGridView.Rows[row.Index].Cells["IP"].Value.ToString(), filePath, row.Index);
                            progressBar.PerformStep();
                        }
                    }
                    else
                    {
                        MessageBox.Show("nonnno", "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UiUnLock();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("ertyui", "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UiUnLock();
                return;
            }

            progressBar.Value = progressBar.Maximum;
            UiUnLock();
        }

        void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.FileName = "Updates " + DateTime.Now.ToString("dd.MM.yyyy HH.mm");

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
            UiLock();

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

            SearchFactor.IpSearch(StartIP.Text, StopIP.Text);
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
                        SearchFactor.Drop(obj);
                    }
                }
            }
        }
    }
}
