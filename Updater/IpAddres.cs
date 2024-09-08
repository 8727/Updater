using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Updater
{
    internal class IpAddres
    {
        public static bool Check(string ip)
        {
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return regex.IsMatch(ip);
        }

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
                        host = serialNumber + " " + factoryNumber + " " + ip;
                    }
                }
                catch
                {
                    host = "Not a Factor";
                }                
            }
            return host;
        }
    }
}
