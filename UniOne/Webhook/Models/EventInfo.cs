using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class EventInfo
    {
        [JsonProperty("event_name")]
        public string Name { get; set; }

        [JsonProperty("event_data")]
        public EventData Data { get; set; }
    }
}
