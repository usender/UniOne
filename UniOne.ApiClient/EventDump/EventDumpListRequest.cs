using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.EventDump
{
    internal class EventDumpListRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.EventDump.List;
    }
}
