using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal class WebhookGetRequest : WebhookBaseRequest
    {
        public WebhookGetRequest(string url) 
            : base(url)
        {
        }

        internal override ApiAction ApiAction  => ApiAction.Webhook.Get;
    }
}