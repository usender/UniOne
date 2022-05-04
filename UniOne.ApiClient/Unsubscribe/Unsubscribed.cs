using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    public class Unsubscribed
    {
        /// <summary>
        /// Unsubscribed email.
        /// </summary>
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Date and time when a recipient unsubscribed, in UTC timezone 
        /// </summary>
        [JsonProperty("unsubscribed_on")]
        public DateTime UnsubscribedOnUtc { get; set; }
    }
}
