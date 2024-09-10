using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

namespace Updater
{
    internal class SearchFactor
    {
        public static uint IpToUInt32(string ipAddress)
        {
            return BitConverter.ToUInt32(IPAddress.Parse(ipAddress).GetAddressBytes().Reverse().ToArray(), 0);
        }

        public static string UInt32ToIp(uint ipAddress)
        {
            return new IPAddress(BitConverter.GetBytes(ipAddress).Reverse().ToArray()).ToString();
        }

        public static string NameComplex(string ip)
        {
            string host = "IP is unavailable";
            PingReply pr = new Ping().Send(ip, 5000);
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
            return host;
        }


        public static void IpSearch(string Start_IP, string Stop_IP)
        {
            uint StartIPv4_UInt32 = IpToUInt32(Start_IP);
            uint EndIPv4_UInt32 = IpToUInt32(Stop_IP);

            if (StartIPv4_UInt32 > EndIPv4_UInt32)
            {
                uint xxx = StartIPv4_UInt32;
                StartIPv4_UInt32 = EndIPv4_UInt32;
                EndIPv4_UInt32 = xxx;
            }

            Task[] tasks = new Task[EndIPv4_UInt32 - StartIPv4_UInt32 + 1];
            int y = 0;
            for (uint i = StartIPv4_UInt32; i <= EndIPv4_UInt32; i++)
            {
                tasks[y] = new Task(() =>
                {
                    Ui.DataGridFactorsAdd(UInt32ToIp(i), NameComplex(UInt32ToIp(i)));
                });
                tasks[y].Start();
                y++;
            }

            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch { }
        }
    }
}
