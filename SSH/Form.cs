using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SSH
{
    public partial class Ui : Form
    {
        public Ui()
        {
            InitializeComponent();
        }

        private void Ui_Load(object sender, EventArgs e)
        {
            string jsonconf = Application.StartupPath.ToString() + "\\updater.conf";
            if (File.Exists(jsonconf))
            {
                string confjson = File.ReadAllText(jsonconf);
                var datajson = new JavaScriptSerializer().Deserialize<dynamic>(confjson);
                Start_IP.Text = datajson["start_ip"];
                Stop_IP.Text = datajson["stop_ip"];


            }
        }


        private void Search_Click(object sender, EventArgs e)
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
        }


    }
}
