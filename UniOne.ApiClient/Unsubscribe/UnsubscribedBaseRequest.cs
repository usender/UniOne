using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal abstract class UnsubscribedBaseRequest : BaseRequest
    {
        protected UnsubscribedBaseRequest(string email)
        {
            EmailAddress = email;
        }

        /// <summary>
        /// Email address to unsubscribed or check
        /// </summary>
        [JsonProperty("address")]
        public string EmailAddress { get; set; }
    }
}
