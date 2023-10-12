using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;
using System;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    /// <summary>
    /// Object with different event properties depending on “event_name”. Below you can see all the properties, “transactional_email_status”-related first and then “transactional_spam_block”-related
    /// </summary>
    public class EventData
    {
        /// <summary>
        /// Job identifier returned earlier by email/send method. Property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// Metadata passed in email/send method in recipients.metadata or global_metadata properties. This property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Recipient’s email. This property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Email delivery status. This property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Event date & time in UTC time zone. This property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("event_time")]
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// URL for “opened” and “clicked” statuses. This property exists only if event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Object with detailed delivery info.Event date & time in UTC time zone. This property exists only if webhook has delivery_info property set to 1 and event_name=“transactional_email_status”
        /// </summary>
        [JsonProperty("delivery_info")]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// Spam block date & time in UTC time zone. This property exists only if event_name=“transactional_spam_block”
        /// </summary>
        [JsonProperty("block_time")]
        public DateTime? BlockTime { get; set; }

        /// <summary>
        /// Spam block type, either single or multiple sending SMTP. For single sending SMTP block in common pool UniOne retries several other SMTPs. This property exists only if event_name=“transactional_spam_block”
        /// </summary>
        [JsonProperty("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// Domain that blocked sending. This property exists only if event_name=“transactional_spam_block”
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Number of sending SMTPs blocked. This property exists only if event_name=“transactional_spam_block”
        /// </summary>
        [JsonProperty("SMTP_blocks_count")]
        public int SmtpBlocksCount { get; set; }

        /// <summary>
        /// Whether it’s a block or unblock event. This property exists only if event_name=“transactional_spam_block”
        /// </summary>
        [JsonProperty("domain_status")]
        public string DomainStatus { get; set; }
    }
}
