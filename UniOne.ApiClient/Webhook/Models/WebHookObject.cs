using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class WebHookObject : WebhookSet
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAtUtc { get; internal set; }
    }
}
