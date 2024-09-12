using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http.Headers;

namespace Updater
{
    internal class UpdateFactor
    {
        static async Task<string> StateAsync(string ipAddress)
        {
            string updateStatus = "undefined";
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), $"http://{ipAddress}/updater/state"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "text/plain");

                        var response = await httpClient.SendAsync(request);
                        response.EnsureSuccessStatusCode();
                        var json = await response.Content.ReadAsStringAsync();
                        var datajson = new JavaScriptSerializer().Deserialize<dynamic>(json);
                        updateStatus = datajson["stage"];
                    }
                }
            }
            catch
            {
                updateStatus = "undefined";
            }

            return updateStatus;
        }

        static async Task<bool> UploadAsync(string ipAddress, string filePath)
        {
            bool updateStatus = false;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"http://{ipAddress}/updater/upload"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "*/*");
                        var multipartContent = new MultipartFormDataContent();
                        var file = new ByteArrayContent(File.ReadAllBytes(filePath));
                        file.Headers.Add("Content-Type", "application/x-gzip");
                        multipartContent.Add(file, "file", Path.GetFileName(filePath));
                        request.Content = multipartContent;

                        var response = await httpClient.SendAsync(request);
                        if (response.StatusCode.ToString() == "OK")
                        {
                            updateStatus = true;
                        }
                    }
                }
            }
            catch
            {
                updateStatus = false;
            }
            return updateStatus;
        }

        static async Task<bool> InstallAsync(string ipAddress)
        {
            bool updateStatus = false;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"http://{ipAddress}/updater/install"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "text/plain");
                        request.Content = new StringContent("");
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                        var response = await httpClient.SendAsync(request);
                        if (response.StatusCode.ToString() == "OK")
                        {
                            updateStatus = true;
                        }
                    }
                }
            }
            catch
            {
                updateStatus = false;
            }
            return updateStatus;
        }

        static async Task<bool> CancelAsync(string ipAddress)
        {
            bool updateStatus = false;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"http://{ipAddress}/updater/cancel"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "*/*");

                        request.Content = new StringContent("");
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                        var response = await httpClient.SendAsync(request);
                    }
                }
            }
            catch
            {
                updateStatus = false;
            }
            return updateStatus;
        }

        public static async Task<bool> SingleFile(string ip, string file, int stroka)
        {
            string fileName = file.Substring(file.LastIndexOf('\\') + 1);
            Ui.StatusDataGridView(stroka, fileName, "Check...");
            string statusState = "";
            bool statusload = false;
            bool statusInstall = false;
            bool statusJob = true;
            int attempts = 5;
            do
            {
                statusState = await StateAsync(ip);

                if (statusState == "undefined" & attempts != 0 | statusState == "uploading" & attempts != 0)
                {
                    await CancelAsync(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    statusJob = false;
                }
            }
            while (statusJob);

            if (statusState != "notStarted")
            {
                Ui.StatusDataGridView(stroka, fileName, "Not Available...");
                //Ui.StepProgressBar();
                return true;
            }
                

            Ui.StatusDataGridView(stroka, fileName, "Loading...");
            statusJob = true;
            attempts = 5;
            do
            {
                statusload = await UploadAsync(ip, file);

                if (!statusload & attempts != 0)
                {
                    //await CancelAsync(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    statusJob = false;
                }
            }
            while (statusJob);

            if (!statusload)
            {
                Ui.StatusDataGridView(stroka, fileName, "Not Loading...");
                //Ui.StepProgressBar();
                return true;
            }

            Ui.StatusDataGridView(stroka, fileName, "Install...");
            statusJob = true;
            attempts = 5;
            do
            {
                statusInstall = await InstallAsync(ip);

                if (!statusInstall & attempts != 0)
                {
                    //await CancelAsync(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    statusJob = false;
                }
            }
            while (statusJob);

            if (!statusInstall)
            {
                Ui.StatusDataGridView(stroka, fileName, "Not Install...");
                //Ui.StepProgressBar();
                return true;
            }

            Ui.StatusDataGridView(stroka, fileName, "Installed");
            //Ui.StepProgressBar();

            return false;
        }
    }
}
