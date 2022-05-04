using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    public class UnsubscribedListResponse : BaseResponse
    {
        /// <summary>
        /// Array of object describing unsubscribed emails
        /// </summary>
        [JsonProperty("unsubscribed")]
        public Unsubscribed[] Unsubscribes { get; set; }
    }
}
