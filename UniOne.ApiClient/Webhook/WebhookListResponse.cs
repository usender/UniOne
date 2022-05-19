using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient.Webhook
{
    public class WebhookListResponse : BaseResponse
    {
        /// <summary>
        /// Array of webhooks objects.
        /// </summary>
        [JsonProperty("objects")]
        public WebHookObject[] WebHookGet { get; internal set; }
    }
}
