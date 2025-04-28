using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityModManager.Objects
{
    internal class FileUploadResult
    {
        public string BinId { get; set; }
        public string FileName { get; set; }
        public string FileHash { get; set; }
        public string PartialHash { get; set; }

        public FileUploadResult()
        {
        }

        public FileUploadResult(string shareCode)
        {
            string[] shareParts = shareCode.Split('#');
            this.BinId = shareParts[1];
            this.PartialHash = shareParts[2];
            this.FileName = shareParts[3] + ".zip";
        }

        public string GetSharingCode()
        {
            return $"#{BinId}#{FileHash.Substring(0,6)}#{Path.GetFileNameWithoutExtension(FileName)}#";
        }
    }
}
