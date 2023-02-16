using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Domain
{
    internal  class ValidateDkimRequest : BaseRequest
    {
        internal ValidateDkimRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiEndpoint Endpoint => ApiEndpoint.Domain.ValidateDkim;

        /// <summary>
        /// Domain to validate DKIM record for
        /// </summary>
        [Required]
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
