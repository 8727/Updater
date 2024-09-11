using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Updater
{
    public partial class Ui : Form
    {
        public static Ui Fr;
        int filesUpdate = 100;
        string filePath = string.Empty;
        //public static Hashtable Camera = new Hashtable();
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
            Fr.Save.Enabled = false;
            Fr.Save.BackgroundImage = Properties.Resources.saveL;
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
            Fr.Save.Enabled = true;
            Fr.Save.BackgroundImage = Properties.Resources.save;
            Fr.Updates.Enabled = true;
            Fr.Updates.BackgroundImage = Properties.Resources.update;
            Fr.dataGridView.Enabled = true;
        }

        public static void DataGridFactorsAdd(string ip, string name)
        {
            Fr.progressBar.PerformStep();
        }

        public static void StepProgressBar()
        {
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

        void checkBoxFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFolder.Checked)
            {
                Selects.Enabled = false;
                string[] tempfiles = Directory.GetFiles(Application.StartupPath, "*.tar.gz", SearchOption.AllDirectories);
                filesUpdate = tempfiles.Count();
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
                    label1.Text = filePath;
                }
            }
        }

        void Updates_Click(object sender, EventArgs e)
        {
            UiLock();
            progressBar.Value = 0;
            if (dataGridView.RowCount != 0)
            {
                if (checkBoxFolder.Checked)
                {
                    if(filesUpdate != 0)
                    {



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

            bool startIp = IpAddres.Check(StartIP.Text);
            bool stopIp = IpAddres.Check(StopIP.Text);

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

            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.Width = 25;
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            dataGridView.Columns.Add(CheckboxColumn);

            dataGridView.Columns.Add("IP", "IP");
            dataGridView.Columns[1].Width = 90;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].ReadOnly = true;

            SearchFactor.IpSearch(StartIP.Text, StopIP.Text);
        }

        void Drop_DragEnter(object sender, DragEventArgs e)
        {
            UiLock();
            progressBar.Value = 0;
            dataGridView.Columns.Clear();

        }

        void Drop_DragDrop(object sender, DragEventArgs e)
        {
            UiLock();
            progressBar.Value = 0;
            dataGridView.Columns.Clear();

        }

    }
}
