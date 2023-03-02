using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// Message options
    /// </summary>
    public class MessageOptions
    {
        /// <summary>
        /// Date and time in “YYYY-MM-DD hh:mm:ss” format in the UTC timezone. Allows schedule sending up to 24 hours in advance.
        /// </summary>
        [JsonProperty("send_at")]
        public DateTime? SendAt { get; set; }

        /// <summary>
        /// Custom unsubscribe link. Read more <see cref="http://docs.unione.io/unsubscribe-link"/>.
        /// </summary>
        [JsonProperty("unsubscribe_url")]
        public string UnsubscribeUrl { get; set; }

        /// <summary>
        /// Backend-domain identifier to send message with.
        /// </summary>
        [JsonProperty("custom_backend_id")]
        public int? CustomBackendId { get; set; }

        /// <summary>
        /// SMTP pool identifier to send message with. If smtp_pool_id is not set, default one for your account/project will be used. You can pay for one or more dedicated IPs and use this option to choose sending using dedicated IP or common pool.
        /// </summary>
        [JsonProperty("smtp_pool_id")]
        public string SmtpPoolId { get; set; }
    }
}