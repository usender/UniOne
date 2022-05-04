using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal class UnsubscribedCheckRequest : UnsubscribedBaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Unsubscribed.Check;

        public UnsubscribedCheckRequest(string email)
            : base(email)
        {
        }
    }
}
