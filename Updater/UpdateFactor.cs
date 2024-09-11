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
        async Task<string> StateAsync(string ipAddress)
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

        async Task<bool> UploadAsync(string ipAddress, string filePath)
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

        async Task<bool> InstallAsync(string ipAddress)
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

        async Task<bool> CancelAsync(string ipAddress)
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

        async Task UploadFactorAsyncFile(string ip, string filePath)
        {
            string status = "";
            bool statusbool = true;
            int attempts = 5;
            do
            {
                status = await StateAsync(ip);

                if (status == "undefined" & attempts != 0 | status == "uploading" & attempts != 0)
                {
                    await CancelAsync(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    statusbool = false;
                }
            }
            while (statusbool);

            if (status != "notStarted")
                return;

            status = "";
            statusbool = true;
            attempts = 5;
            do
            {
                if (await UploadAsync(ip, filePath) & attempts != 0)
                {
                    await CancelAsync(ip);
                    attempts--;
                    Thread.Sleep(500);
                }
                else
                {
                    statusbool = false;
                }
            }
            while (statusbool);
            



        }









    }
}
