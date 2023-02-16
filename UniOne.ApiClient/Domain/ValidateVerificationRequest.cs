using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Domain
{
    internal class ValidateVerificationRequest : BaseRequest
    {
        public ValidateVerificationRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiEndpoint Endpoint => ApiEndpoint.Domain.ValidateVerificationRecord;

        /// <summary>
        /// Domain to validate verification record for
        /// </summary>
        [Required]
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
