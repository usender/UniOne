using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Common
{
    public class Page
    {
        public Page()
            : this(50, 0)
        {

        }

        public Page(int limit, int offset)
        {
            Limit = limit > 0 ? limit : 50;
            Offset = offset > 0 ? offset : 0;
        }

        /// <summary>
        /// Entry count
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Offset entries
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}