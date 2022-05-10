using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal  class UnsubscribedSetRequest : UnsubscribedBaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Unsubscribed.Set;

        public UnsubscribedSetRequest(string email)
            : base(email)
        {
        }
    }
}
