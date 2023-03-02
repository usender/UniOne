using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Domain
{
    public class GetDnsRecordResponse : BaseResponse
    {
        /// <summary>
        /// Domain to get DNS records for
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; internal set; }

        /// <summary>
        /// Record to be added “as is” to verify ownership of this domain
        /// </summary>
        [JsonProperty("verification-record")]
        public string VerificationRecord { get; internal set; }

        /// <summary>
        /// DKIM signature for the domain. This property contains only the key part, you should prepend it with “k=rsa, p=” part for the record to be valid (see example)
        /// </summary>
        [JsonProperty("dkim")]
        public string Ddkim { get; internal set; }
    }
}
