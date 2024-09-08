using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace Updater
{
    internal class UpdateFactor
    {
        string State(string ipAddress)
        {
            string updateStatus = "undefined";
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create($"http://{ipAddress}/updater/state");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                using (StreamReader stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
                {
                    string factorJson = stream.ReadToEnd();
                    var datajson = new JavaScriptSerializer().Deserialize<dynamic>(factorJson);
                    updateStatus = datajson["stage"];
                }
            }
            catch
            {
                updateStatus = "undefined";
            }

            return updateStatus;
        }

        bool Upload(string ipAddress, string filePath)
        {
            bool updateStatus = false;
            string url = $"http://{ipAddress}/updater/upload";

            return updateStatus;
        }

        bool Install(string ipAddress)
        {
            bool updateStatus = false;
            string url = $"http://{ipAddress}/updater/install";

            return updateStatus;
        }

        bool Cancel(string ipAddress)
        {
            bool updateStatus = false;
            string url = $"http://{ipAddress}/updater/cancel";

            return updateStatus;
        }

        void UploadFactor(string ip, string filePath, int row, int column)
        {
            bool status = true;
            int attempts = 5;
            do
            {
                if (State(ip) != "uploading" & attempts != 0)
                {
                    Cancel(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    status = false;
                }
            }
            while (status);

            status = true;
            attempts = 5;
            do
            {
                if (Upload(ip, filePath) & attempts != 0)
                {
                    Cancel(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    status = false;
                }
            }
            while (status);
            



        }









    }
}
