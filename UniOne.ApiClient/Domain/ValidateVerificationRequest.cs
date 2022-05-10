using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Domain
{
    internal class ValidateVerificationRequest : BaseRequest
    {
        public ValidateVerificationRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Domain.ValidateVerificationRecord;

        /// <summary>
        /// Domain to validate verification record for
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
