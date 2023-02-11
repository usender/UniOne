using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Tag
{
    internal class TagDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Tag.Delete;

        internal TagDeleteRequest(int tagId)
        {
            TagId = tagId;
        }

        /// <summary>
        /// Unique tag id
        /// </summary>
        [JsonProperty("tag_id")]
        internal int TagId { get; set; }
    }
}
