using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Domain
{
    internal class GetDnsRecordRequest : BaseRequest
    {
        public GetDnsRecordRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Domain.GetDnsRecords;

        /// <summary>
        /// Domain to get DNS records for
        /// </summary>
        [Required]
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
