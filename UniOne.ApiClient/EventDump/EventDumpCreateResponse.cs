using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.EventDump
{
    public class EventDumpCreateResponse : BaseResponse
    {
        /// <summary>
        /// Dump identifier, used to call the event-dump/get method.
        /// </summary>
        [JsonProperty("dump_id")]
        internal string DumpId { get; set; }
    }
}
