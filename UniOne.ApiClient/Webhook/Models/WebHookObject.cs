using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class WebHookObject : WebhookSet
    {
        /// <summary>
        /// Webhook unique identifier
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; internal set; }

        /// <summary>
        /// Webhook properties last update date and time in UTC timezone
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAtUtc { get; internal set; }
    }
}