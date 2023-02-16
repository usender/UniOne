using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.EventDump
{
    internal class EventDumpDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.EventDump.Delete;

        internal EventDumpDeleteRequest(string dumpId)
        {
            DumpId = dumpId;
        }

        /// <summary>
        /// Dump identifier, obtained via the event-dump/create method
        /// </summary>
        [JsonProperty("dump_id")]
        internal string DumpId { get; set; }
    }
}
