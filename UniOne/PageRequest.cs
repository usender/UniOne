using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient
{
    internal abstract class PageRequest : BaseRequest
    {
        internal PageRequest(Page page)
        {
            Limit = page.Limit;
            Offset = page.Offset;
        }

        /// <summary>
        /// Limits the number of records returned. Default is 50.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Limits the number of records returned. Default is 50.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}
