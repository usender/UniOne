using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Domain
{
    internal  class ValidateDkimRequest : BaseRequest
    {
        internal ValidateDkimRequest(string domain)
        {
            Domain = domain;
        }

        internal override ApiAction ApiAction => ApiAction.Domain.ValidateDkim;

        /// <summary>
        /// Domain to validate DKIM record for
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }
}
