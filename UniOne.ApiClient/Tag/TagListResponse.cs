using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Tag
{
    public class TagListResponse : BaseResponse
    {
        /// <summary>
        /// An list of objects containing data for user-defined tags
        /// </summary>
        [JsonProperty("tags")]
        public List<TagItem> Tags { get; internal set; }
    }
}
