using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class EventInfo
    {
        /// <summary>
        /// Type of event data contained in event_data field, either “transactional_email_status” or “transactional_spam_block”
        /// </summary>
        [JsonProperty("event_name")]
        public string Name { get; set; }

        /// <summary>
        /// Object with different event properties depending on “event_name”. Below you can see all the properties, “transactional_email_status”-related first and then “transactional_spam_block”-related
        /// </summary>
        [JsonProperty("event_data")]
        public EventData Data { get; set; }
    }
}
