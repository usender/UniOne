using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal class WebhookListRequest : PageRequest
    {
        public WebhookListRequest(Page page)
            :base(page)
        {

        }

        internal override ApiAction ApiAction => ApiAction.Webhook.List;
    }
}