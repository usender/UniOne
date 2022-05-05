using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// Message response
    /// </summary>
    public class EmailMessageResponse : BaseResponse
    {
        /// <summary>
        /// Job identifier, might be useful for investigating errors
        /// </summary>
        [JsonProperty("job_id")]
        public string JobId { get; internal set; }

        /// <summary>
        /// Array of recipients emails successfully accepted for sending
        /// </summary>
        [JsonProperty("emails")]
        public string[] Emails { get; internal set; }

        /// <summary>
        /// Object with emails rejected for sending as property names and their statuses as property values
        /// </summary>
        [JsonProperty("failed_emails")]
        public Dictionary<string, string> FailedEmails { get; internal set; }
    }
}