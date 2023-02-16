using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.EventDump
{
    internal class EventDumpCreateRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.EventDump.Create;

        internal EventDumpCreateRequest()
        {
            Limit = 50;
            Format = EventDumpFormat.Csv;
            Filter = new EventDumpFilter();
        }

        /// <summary>
        /// Date and time in YYYY-MM-DD hh:mm:ss format, specifying period start time. Data is stored for up to 32 days, depending on your tariff.
        /// </summary>
        [JsonProperty("start_time")]
        internal DateTime StartTime { get; set; }

        /// <summary>
        /// Date and time in YYYY-MM-DD hh:mm:ss format, specifying period end time (non-inclusive).
        /// </summary>
        [JsonProperty("end_time")]
        internal DateTime? EndTime { get; set; }

        /// <summary>
        /// Maximum number of events returned (default is 50). If this value is over 100 000, several files will be created, each having 100 000 events maximum.
        /// </summary>
        [JsonProperty("limit")]
        internal int? Limit { get; set; }

        /// <summary>
        /// For accounts with projects enabled, the value all_projects=true allows to fetch data for all existing projects.
        /// </summary>
        [JsonProperty("all_projects")]
        internal bool? AllProjects { get; set; }

        /// <summary>
        /// Field delimiter, can be set to either ‘,’ or ‘;’, defaults to ‘,’.
        /// </summary>
        [JsonProperty("delimiter")]
        internal string Delimiter { get; set; }

        /// <summary>
        /// File format, either “csv” (default) or “csv_gzip”.
        /// </summary>
        [JsonProperty("format", ItemConverterType = typeof(StringEnumConverter))]
        internal EventDumpFormat? Format { get; set; }

        /// <summary>
        /// An object with the properties of the event dump filter.
        /// </summary>
        [JsonProperty("filter")]
        internal EventDumpFilter Filter { get; set; }
    }
}
