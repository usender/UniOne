using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.EventDump
{
    internal class EventDumpGetRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.EventDump.Get;

        internal EventDumpGetRequest(string dumpId)
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
