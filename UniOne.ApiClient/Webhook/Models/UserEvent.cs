using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class UserEvent
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("events")]
        public EventInfo[] Events { get; set; }
    }
}
