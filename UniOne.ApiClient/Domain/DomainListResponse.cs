using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Domain
{
    public class DomainListResponse : BaseResponse
    {
        /// <summary>
        /// Array of objects describing domains
        /// </summary>
        [JsonProperty("domains")]
        public DomainItem[] Domains { get; internal set; }
    }
}
