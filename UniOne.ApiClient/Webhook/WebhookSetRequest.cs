using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Infrastructure.JsonConverters;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal class WebhookSetRequest : BaseRequest
    {
        public WebhookSetRequest(WebhookSet webhookSet)
        {
            Url = webhookSet.Url;
            Status = webhookSet.Status;
            EventFormat = webhookSet.EventFormat;
            DeliveryInfo = webhookSet.DeliveryInfo;
            MaxParallel = webhookSet.MaxParallel;
            SingleEvent = webhookSet.SingleEvent;
            Events = webhookSet.Events;
        }

        internal override ApiAction ApiAction => ApiAction.Webhook.List;

        /// <summary>
        /// URL that will receive the notification when an event occurs. The URL should be unique for a user or a project. Only ASCII characters are supported for now in URL, please convert to Punycode if you need to use non-ASCII characters
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Webhook status, “active” by default. “disabled” means that webhook has been disabled by the user, “stopped” means that webhook has been stopped by the system after 24h of failed calls (with minimum of 10 distinct events)
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebhookStatus Status { get; set; }

        /// <summary>
        /// Notification format. “json_post”(default) or “json_post_gzip”
        /// </summary>
        [JsonProperty("event_format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebhookEventFormat EventFormat { get; set; }

        /// <summary>
        /// accepts 0 and 1. Default: 0
        /// <list type="bullet">
        /// <item>
        ///     <term>1</term>
        ///     <description>the detailed delivery info will be returned
        ///         (if status equals hard_bounce or soft_bounce the information about non-delivery will be returned;
        ///          if status equals opened or clicked the information recipient's operating system, browser and IP address will be returned)
        ///     </description>
        /// </item>
        /// <item>
        ///     <term>0</term>
        ///     <description>the detailed delivery info won't be returned</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonConverter(typeof(IntToBoolConverter))]
        [JsonProperty("delivery_info")]
        public bool DeliveryInfo { get; set; }

        /// <summary>
        /// accepts 0 and 1. Default: 0
        /// <list type="bullet">
        /// <item>
        ///     <term>0</term>
        ///     <description>Webhook notifications are arranged into arrays</description>
        /// </item>
        /// <item>
        ///     <term>1</term>
        ///     <description>Single event causes a single Webhook notification. No arrays returned</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonConverter(typeof(IntToBoolConverter))]
        [JsonProperty("single_event")]
        public bool SingleEvent { get; set; }

        /// <summary>
        /// Maximum quantity of permitted parallel queries to your server. The more your server can handle - the better. Accepts values from 5 to 100. Default: 10
        /// </summary>
        [JsonProperty("maxParallel")]
        [Range(5, 100)]
        public int MaxParallel { get; set; }

        /// <summary>
        /// Object containing events to notify of
        /// </summary>
        [JsonProperty("events")]
        public HookEvent Events { get; set; }
    }
}
