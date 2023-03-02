using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient.Webhook
{
    public class WebhookGetResponse : BaseResponse
    {
        /// <summary>
        /// Object with all the webhook properties.
        /// </summary>
        [JsonProperty("object")]
        public WebHookObject WebHookGet { get; internal set; }
    }
}
