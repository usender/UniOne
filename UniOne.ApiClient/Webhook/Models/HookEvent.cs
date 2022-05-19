using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Email;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class HookEvent
    {
        /// <summary>
        /// Email statuses to notify. Default: include all <see cref="MessageStatus"/>
        /// <see cref="http://eu1.unione.io/ru/docs/page/webhook_set_v1#status"/>
        /// </summary>
        [JsonProperty("email_status", ItemConverterType = typeof(StringEnumConverter))]
        public MessageStatus[] EmailStatuses { get; set; }

        /// <summary>
        /// Your name may appear around GitHub where you contribute or are mentioned. You can remove it at any time. Default: [*]
        /// <see cref="http://eu1.unione.io/ru/docs/page/Spam_Blocking"/>
        /// </summary>
        [JsonProperty("spam_block")]
        public string[] SpamBlock { get; set; }
    }
}