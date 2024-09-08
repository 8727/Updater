using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Updater
{
    public partial class Ui : Form
    {
        int filesUpdate = 100;
        public Ui()
        {
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

            label1.Text = IpAddres.IpToUInt32(StartIP.Text).ToString();
            label2.Text = IpAddres.IpToUInt32(StopIP.Text).ToString();

            uint StartIPv4_Int32 = IpAddres.IpToUInt32(StartIP.Text);
            uint EndIPv4_Int32 = IpAddres.IpToUInt32(StopIP.Text);

            if (StartIPv4_Int32 > EndIPv4_Int32)
            {
                uint xxx = StartIPv4_Int32;
                StartIPv4_Int32 = EndIPv4_Int32;
                EndIPv4_Int32 = xxx;
            }

            for (uint i = StartIPv4_Int32; i <= EndIPv4_Int32; i++)
            {
                listBox1.Items.Add(IpAddres.UInt32ToIp(i));
                listBox1.Items.Add(IpAddres.NameComplex(IpAddres.UInt32ToIp(i)));
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
    }
}
