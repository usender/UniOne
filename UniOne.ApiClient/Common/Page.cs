using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Common
{
    public class Page
    {
        /// <summary>
        /// Entry count
        /// </summary>
        [JsonProperty("limit")] 
        public int Limit { get; set; } = 50;

        /// <summary>
        /// Offset entries
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}
