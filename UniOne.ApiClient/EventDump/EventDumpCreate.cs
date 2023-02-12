using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.EventDump
{
    public class EventDumpCreate
    {
        /// <summary>
        /// Date and time in YYYY-MM-DD hh:mm:ss format, specifying period start time. Data is stored for up to 32 days, depending on your tariff.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Date and time in YYYY-MM-DD hh:mm:ss format, specifying period end time (non-inclusive).
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Maximum number of events returned (default is 50). If this value is over 100 000, several files will be created, each having 100 000 events maximum.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// For accounts with projects enabled, the value all_projects=true allows to fetch data for all existing projects.
        /// </summary>
        public bool? AllProjects { get; set; }

        /// <summary>
        /// Field delimiter, can be set to either ‘,’ or ‘;’, defaults to ‘,’.
        /// </summary>
        public string Delimiter { get; set; }

        /// <summary>
        /// File format, either “csv” (default) or “csv_gzip”.
        /// </summary>
        public EventDumpFormat? Format { get; set; }

        /// <summary>
        /// An object with the properties of the event dump filter.
        /// </summary>
        public EventDumpFilter Filter { get; set; }
    }

    public class EventDumpFilter
    {
        /// <summary>
        /// Job identifier returned earlier by email/send method
        /// </summary>
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// Email status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter))]
        public MessageStatus? Status { get; set; }

        /// <summary>
        /// UniOne public detailed delivery status, you can pass several values at once, comma-separated. Some possible values are
        /// </summary>
        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Sender email address
        /// </summary>
        [JsonProperty("email_from")]
        public string EmailFrom { get; set; }

        /// <summary>
        /// Recipient domain
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Campaign identifier, unsigned decimal integer or UUID up to 128-bit, passed in metadata with name “campaign_id” (name is configurable thru support).
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }
}
