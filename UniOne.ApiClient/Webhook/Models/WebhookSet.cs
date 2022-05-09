using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Email;
using Sender.UniOne.ApiClient.Infrastructure.Helpers;
using Sender.UniOne.ApiClient.Infrastructure.JsonConverters;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    /// <summary>
    /// Webhook object
    /// </summary>
    public class WebhookSet
    {
        public WebhookSet()
            : this(null)
        { }

        public WebhookSet(string url)
        {
            Url = url;
            MaxParallel = 10;
            DeliveryInfo = true;
            Status = WebhookStatus.Active;
            EventFormat = WebhookEventFormat.JsonPost;

            Events = new HookEvent
            {
                SpamBlock = new[] { "*" },
                EmailStatuses = EnumHelper.GetValues<MessageStatus>().ToArray()
            };
        }

        /// <summary>
        /// URL that will receive the notification when an event occurs
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Webhook status, “active” by default. “disabled” means that webhook has been disabled by the user, “stopped” means that webhook has been stopped by the system after 24h of failed calls (with minimum of 10 distinct events).
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebhookStatus Status { get; set; }

        /// <summary>
        /// Notification format. “json_post”(default) or “json_post_gzip”.
        /// </summary>
        [JsonProperty("event_format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebhookEventFormat EventFormat { get; set; }

        /// <summary>
        /// Default: True
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
        /// accepts 0 and 1. Default: false
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
        /// maximum quantity of parallel queries to server. Accepts values from 5 to 100. Default: 10
        /// </summary>
        [JsonProperty("maxParallel")]
        public int MaxParallel { get; set; }

        /// <summary>
        /// events, created by request (see above)
        /// </summary>
        [JsonProperty("events")]
        public HookEvent Events { get; set; }
    }
}