using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.Domain
{
    internal class DomainListRequest : PageRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Domain.List;

        public DomainListRequest(string domain, Page page)
            : base(page)
        {
            Domain = domain;
        }

        /// <summary>
        /// Optional domain name if you want to get the status of single domain only
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}