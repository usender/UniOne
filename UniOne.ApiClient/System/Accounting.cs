using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.System
{
    public class Accounting
    {
        [JsonProperty("period_start")]
        public DateTime PeriodStartUtc { get; set; }

        [JsonProperty("period_end")]
        public DateTime PeriodEndUtc { get; set; }

        [JsonProperty("emails_included")]
        public long EmailsIncluded { get; set; }

        [JsonProperty("emails_sent")]
        public long EmailsSent { get; set; }
    }
}
