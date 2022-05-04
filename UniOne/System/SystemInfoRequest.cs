using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.System
{
    internal class SystemInfoRequest : BaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.System.Info;
    }
}
