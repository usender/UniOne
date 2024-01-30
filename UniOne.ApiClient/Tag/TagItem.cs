using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Tag
{
    public class TagItem
    {
        /// <summary>
        /// Unique tag id
        /// </summary>
        [JsonProperty("tag_id")]
        public int TagId { get; internal set; }

        /// <summary>
        /// Tag name
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; internal set; }
    }
}
