using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Domain
{
    internal class GetDnsRecordRequest : BaseRequest
    {
        public GetDnsRecordRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiAction ApiAction => ApiAction.Domain.GetDnsRecords;

        /// <summary>
        /// Domain to get DNS records for
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
