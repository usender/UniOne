using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal class WebhookDeleteRequest : WebhookBaseRequest
    {
        public WebhookDeleteRequest(string url)
            : base(url)
        {
           
        }

        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Webhook.Delete;
    }
}
