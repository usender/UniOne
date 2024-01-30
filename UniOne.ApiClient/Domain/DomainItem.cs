using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Domain
{
    public class DomainItem
    {
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; internal set; }

        /// <summary>
        /// Object describing verification record value and status
        /// </summary>
        [JsonProperty("verification-record")]
        public VerificationRecord VerificationRecord { get; internal set; }

        /// <summary>
        /// Object describing DKIM record value and status
        /// </summary>
        [JsonProperty("dkim")]
        public Dkim Dkim { get; internal set; }
    }

    public class VerificationRecord
    {
        /// <summary>
        /// Record to be added “as is” to verify ownership of this domain
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; internal set; }

        /// <summary>
        /// Only domains with “confirmed” verification record are allowed as sender domains
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; internal set; }
    }

    public class Dkim
    {
        /// <summary>
        /// DKIM signature for the domain. This property contains only the key part, you should prepend it with “k=rsa, p=” part for the record to be valid (see domain/get-dns-records)
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; internal set; }

        /// <summary>
        /// Only domains with “active” DKIM record are allowed as sender domains
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; internal set; }
    }
}