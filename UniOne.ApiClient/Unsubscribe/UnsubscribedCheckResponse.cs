using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    public class UnsubscribedCheckResponse : BaseResponse
    {
        /// <summary>
        /// Email that was checked
        /// </summary>
        [JsonProperty("address")]
        public string EmailAddress { get; internal set; }

        /// <summary>
        /// True if unsubscribed, false if not
        /// </summary>
        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; internal set; }
    }
}
