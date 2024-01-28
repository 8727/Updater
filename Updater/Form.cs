using System;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Updater
{
    public partial class Ui : Form
    {
        public Ui()
        {
            InitializeComponent();
        }

        void Ui_Load(object sender, EventArgs e)
        {
            string jsonconf = Application.StartupPath.ToString() + "\\updater.conf";
            if (File.Exists(jsonconf))
            {
                string confjson = File.ReadAllText(jsonconf);
                var datajson = new JavaScriptSerializer().Deserialize<dynamic>(confjson);
                Start_IP.Text = datajson["start_ip"];
                Stop_IP.Text = datajson["stop_ip"];
                updateAlll.Checked = datajson["update_on_match"];
                folderUpdate.Checked = datajson["update_folder"];
                //label1.Text = datajson["streams"].ToString();

/*                Search.Focus();*/
            }
        }

        void Search_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            bool startIp = regex.IsMatch(Start_IP.Text);
            bool stopIp = regex.IsMatch(Stop_IP.Text);
            string send = "";
            if (!startIp)
            {
                send = $"Incorrect Start address: {Start_IP.Text}";
            }
            if ((!startIp) & (!stopIp))
            {
                send += "\n";
            }
            if (!stopIp)
            {
                send += $"Incorrect Stop address: {Stop_IP.Text}";
            }
            if ((!startIp) | (!stopIp))
            {
                MessageBox.Show(send, "IP address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(this.LabelInfo);
            LabelInfo.Text = "Search...";

            //panel1.Controls.Clear();
            //panel1.Controls.Add(this.LabelInfo);
            //LabelInfo.Text = "Not found.";

/*            panel1.Controls.Clear();


            Console.Write("No! ");




            panel1.Controls.Add(this.listView1);*/







            //Scan_IP.Search();

            //LabelSearch.TabIndex = 1;


        }

        void Save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv) | *.csv";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        void Select_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog.Filter = "Firmware(*.tar.gz) | *.tar.gz";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        void Update_Click(object sender, EventArgs e)
        {
            unZip(@"D:\03 decision_1.1.7-dev-tx2.tar.gz", @"D:\2.tar");
        }

        void unZip(string pathSrc, string pathDest)
        {
            try
            {
                using (var fs = File.OpenRead(pathSrc))
                {
                    using (var decompressor = new GZipStream(fs, CompressionMode.Decompress))
                    {
                        using (var output = File.Create(pathDest))
                        {
                            byte[] buffer = new byte[2048];
                            int n;
                            while ((n = decompressor.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, n);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

