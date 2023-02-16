using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Tag
{
    internal class TagDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Tag.Delete;

        internal TagDeleteRequest(int tagId)
        {
            TagId = tagId;
        }

        /// <summary>
        /// Unique tag id
        /// </summary>
        [Required]
        [JsonProperty("tag_id")]
        internal int TagId { get; set; }
    }
}
