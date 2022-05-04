using System;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Email;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class EventData
    {
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("event_time")]
        public DateTime? DateTime { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("delivery_info")]
        public DeliveryInfo DeliveryInfo { get; set; }


        [JsonProperty("block_time")]
        public DateTime? BlockTime { get; set; }

        [JsonProperty("block_type")]
        public string BlockType { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("SMTP_blocks_count")]
        public string SmtpBlocksCount { get; set; }

        [JsonProperty("domain_status")]
        public string DomainStatus { get; set; }
    }
}
