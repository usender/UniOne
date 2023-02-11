using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.EventDump
{
    public class EventDumpListResponse : BaseResponse
    {
        /// <summary>
        /// An object with the properties of the event dump
        /// </summary>
        [JsonProperty("event_dumps")]
        public List<EventDump> EventDumps { get; set; }
    }
}
