using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Updater
{
    public partial class Ui : Form
    {
        public static Ui Fr;
        int filesUpdate = 100;
        public static Hashtable Camera = new Hashtable();
        public Ui()
        {
            Fr = this;
            InitializeComponent();
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
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog.Filter = "Firmware Files (*.tar.gz) | *.tar.gz";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = openFileDialog.SafeFileName;
                    labelTextBox.Text = openFileDialog.SafeFileName;
                    filePath = openFileDialog.FileName;                  
                }
            }
        }

        void Updates_Click(object sender, EventArgs e)
        {
            






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

        private void Search_Click(object sender, EventArgs e)
        {
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

        public static void DataGridFactorsAdd(string ip, string name)
        {
            int rowNumbe = Fr.dataGridView.Rows.Add();
            Fr.dataGridView.FirstDisplayedScrollingRowIndex = rowNumbe;
            Fr.dataGridView.Rows[rowNumbe].Cells[0].Value = true;
            Fr.dataGridView.Rows[rowNumbe].Cells[1].Value = ip;
            Fr.dataGridView.Rows[rowNumbe].Cells[2].Value = name;
            Fr.progressBar.PerformStep();
        }
    }
}
