using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Tag
{
    internal class TagListRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Tag.List;
    }
}
