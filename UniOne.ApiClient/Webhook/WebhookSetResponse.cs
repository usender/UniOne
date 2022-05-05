using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient.Webhook
{
    public class WebhookSetResponse : BaseResponse
    {
        [JsonProperty("object")]
        public WebHookObject WebHookGet { get; internal set; }
    }
}
