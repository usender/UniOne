using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.System
{
    internal class SystemInfoRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.System.Info;
    }
}
