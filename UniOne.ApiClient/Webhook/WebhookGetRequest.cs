using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal class WebhookGetRequest : WebhookBaseRequest
    {
        public WebhookGetRequest(string url) 
            : base(url)
        {
        }

        internal override ApiEndpoint Endpoint  => ApiEndpoint.Webhook.Get;
    }
}