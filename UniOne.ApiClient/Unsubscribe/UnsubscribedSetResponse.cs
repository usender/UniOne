using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    public class UnsubscribedSetResponse : BaseResponse
    {
        /// <summary>
        /// The unsubscribed email
        /// </summary>
        [JsonProperty("address")]
        public string EmailAddress { get; internal set; }

        /// <summary>
        /// Unsubscription process details
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; internal set; }
    }
}
