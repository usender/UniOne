using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.System
{
    /// <summary>
    /// Object with accounting period properties. Present only if the API key used for request is the user API key
    /// </summary>
    public class Accounting
    {
        /// <summary>
        /// Date and time of accounting period start in UTC
        /// </summary>
        [JsonProperty("period_start")]
        public DateTime PeriodStartUtc { get; internal set; }

        /// <summary>
        /// Date and time of accounting period end
        /// </summary>
        [JsonProperty("period_end")]
        public DateTime PeriodEndUtc { get; internal set; }

        /// <summary>
        /// Number of emails included into accounting period
        /// </summary>
        [JsonProperty("emails_included")]
        public long EmailsIncluded { get; internal set; }

        /// <summary>
        /// Number of emails sent during accounting period. Can be bigger than emails_included in case of overage
        /// </summary>
        [JsonProperty("emails_sent")]
        public long EmailsSent { get; internal set; }
    }
}