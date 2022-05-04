using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal  class UnsubscribedSetRequest : UnsubscribedBaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Unsubscribed.Set;

        public UnsubscribedSetRequest(string email)
            : base(email)
        {
        }
    }
}
