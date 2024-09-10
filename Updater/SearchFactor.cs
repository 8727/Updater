﻿using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Web.Script.Serialization;


namespace Updater
{
    internal class SearchFactor
    {
        public static List<string> computersList = new List<string>();

        static uint IpToUInt32(string ipAddress)
        {
            return BitConverter.ToUInt32(IPAddress.Parse(ipAddress).GetAddressBytes().Reverse().ToArray(), 0);
        }

        static string UInt32ToIp(uint ipAddress)
        {
            return new IPAddress(BitConverter.GetBytes(ipAddress).Reverse().ToArray()).ToString();
        }

        static async Task NameComplex(string ip)
        {
            string host = "IP is unavailable";
            PingReply pr = await new Ping().SendPingAsync(ip, 5000);
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
            Ui.DataGridFactorsAdd(ip, host);
        }

        public static void IpSearch(string Start_IP, string Stop_IP)
        {
            computersList.Clear();
            uint StartIPv4_UInt32 = IpToUInt32(Start_IP);
            uint EndIPv4_UInt32 = IpToUInt32(Stop_IP);

            if (StartIPv4_UInt32 > EndIPv4_UInt32)
            {
                uint xxx = StartIPv4_UInt32;
                StartIPv4_UInt32 = EndIPv4_UInt32;
                EndIPv4_UInt32 = xxx;
            }

            for (uint i = StartIPv4_UInt32; i <= EndIPv4_UInt32; i++)
            {
                computersList.Add(UInt32ToIp(i));
            }

            Ui.SetMaxProgressBar(computersList.Count);

            Task[] tasks = new Task[computersList.Count];
            for (int i = 0; i < computersList.Count; i++)
            {
                tasks[i] = NameComplex(computersList.ElementAt<string>(i));
            }
            
        }
    }
}
