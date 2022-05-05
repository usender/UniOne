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

        [JsonProperty("verification-record")]
        public string VerificationRecord { get; internal set; }

        [JsonProperty("dkim")]
        public string Ddkim { get; internal set; }
    }
}
