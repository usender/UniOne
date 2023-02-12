using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sender.UniOne.ApiClient.EventDump
{
    public class EventDump
    {
        /// <summary>
        /// Dump ID received by the method event-dump/create.
        /// </summary>
        [JsonProperty("dump_id")]
        public string DumpId { get; set; }

        /// <summary>
        /// Dump ID received by the method event-dump/create.
        /// </summary>
        [JsonProperty("event_dumps")]
        public string EventDumps { get; set; }

        /// <summary>
        /// Task status, possible values are:
        /// </summary>
        [JsonProperty("dump_status", ItemConverterType = typeof(StringEnumConverter))]
        public EventDumpStatus DumpStatus { get; set; }

        /// <summary>
        /// An array of objects, each representing a file, ready for download. You may start downloading everything listed in “files” even if “dump_status” is still “in_process”. If there are no events, according to the specified parameters, an empty array will be returned.
        /// </summary>
        [JsonProperty("files")]
        public List<EventDumpFile> Files { get; set; }
    }

    public class EventDumpFile
    {
        /// <summary>
        /// Use this unique URL to download the requested dump file (either .csv or .csv.gz, depending on your request).
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
    }
}
