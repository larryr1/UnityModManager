using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UnityModManager.Objects.Lib
{
    internal class FileBinOperations
    {
        public static async Task<string> UploadFileToBinAsync(string filePath)
        {
            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            {
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var fileName = Path.GetFileName(filePath);

                var streamContent = new StreamContent(fileStream);
                streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                content.Add(streamContent, "file", fileName);

                string binId = "UMM" + Guid.NewGuid().ToString();
                var uploadUrl = $"https://filebin.net/{binId}/{fileName}";
                var response = await client.PostAsync(uploadUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Failed to upload file. Status: {response.StatusCode}, Response: {responseBody}");
                }

                System.TimeoutException
            }
        }

        public static async Task LockBinAsync(string binId)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Put, $"https://filebin.net/{binId}"))
            {
                // Empty content with correct content type
                request.Content = new StringContent(string.Empty);
                request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain");

                var response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Failed to lock bin. Status: {response.StatusCode}, Response: {responseBody}");
                }
            }
        }
    }
}
