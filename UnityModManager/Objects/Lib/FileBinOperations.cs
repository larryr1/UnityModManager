using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UnityModManager.Objects.Lib
{
    internal class FileBinOperations
    {
        public static async Task<FileUploadResult> UploadFileToBinAsync(string filePath)
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
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Failed to upload file. Status: {response.StatusCode}, Response: {responseBody}");
                }

                JObject parsedJson = JObject.Parse(responseBody);

                return new FileUploadResult
                {
                    BinId = parsedJson["bin"]["id"].ToString(),
                    FileName = parsedJson["file"]["filename"].ToString(),
                    FileHash = parsedJson["file"]["sha256"].ToString()
                };
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

        public static async Task<string> DownloadBinContentAsync(FileUploadResult opInfo)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Send a GET request to the file URL
                    HttpResponseMessage response = await client.GetAsync($"https://filebin.net/{opInfo.BinId}/{opInfo.FileName}");
                    response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not successful

                    // Read the content of the file as a string (you can adjust this to suit the file format)
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                // Save the bytes to a file
                    string filePath = Path.Combine(Program.SelectedGame.SteamFolderPath, "BepInEx", "UMM_Profiles", "DL-" + Guid.NewGuid().ToString().Substring(0,6) + "-" + opInfo.FileName);
                    await File.WriteAllBytesAsync(filePath, fileBytes);

                    return filePath;
                }
                catch (Exception ex)
                {
                    // Handle errors (e.g., network issues, file not found)
                    return $"Error downloading file: {ex.Message}";
                }
            }
        }
    }
}
