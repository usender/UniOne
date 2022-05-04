using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class WebHookObject : WebhookSet
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAtUtc { get; set; }
    }
}
