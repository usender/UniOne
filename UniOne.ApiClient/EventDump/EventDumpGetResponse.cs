using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.EventDump
{
    public class EventDumpGetResponse : BaseResponse
    {
        /// <summary>
        /// An object with the properties of the event dump
        /// </summary>
        [JsonProperty("event_dump")]
        public EventDump EventDump { get; internal set; }
    }
}
