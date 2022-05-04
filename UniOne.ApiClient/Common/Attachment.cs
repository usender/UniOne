using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Common
{
    /// <summary>
    /// Inline attachment parameter
    /// </summary>
    public class Attachment
    {
        public Attachment()
        { }

        public Attachment(string name, Stream fileBody)
            : this(name, ConvertToBytes(fileBody))
        { }

        public Attachment(string name, byte[] fileBody)
            : this(name, Convert.ToBase64String(fileBody))
        { }

        public Attachment(string name, string fileBodyBase64)
        {
            Name = name;
            Content = fileBodyBase64;
        }

        /// <summary>
        /// MIME type. If unsure, use “application/octet-stream”
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = "application/octet-stream";

        /// <summary>
        /// Attachment name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// File in base64, for using in HTML should be set as "<img src="cid:IMAGECID">"
        /// Maximum file size 7MB (9786710 bytes in base64).
        /// </summary>
        [JsonProperty("content")]
        [MaxLength(9786710)]
        public string Content { get; set; }
        
        private static byte[] ConvertToBytes(Stream stream)
        {
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
