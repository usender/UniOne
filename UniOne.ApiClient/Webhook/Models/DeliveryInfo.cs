using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    /// <summary>
    /// Object with detailed delivery info.Event date & time in UTC time zone in “YYYY-MM-DD hh:mm:ss” format.
    /// </summary>
    public class DeliveryInfo
    {
        /// <summary>
        /// UniOne internal detailed delivery status
        /// </summary>
        [JsonProperty("delivery_status")]
        public string Status { get; set; }

        /// <summary>
        /// SMTP response
        /// </summary>
        [JsonProperty("destination_response")]
        public string DestinationResponse { get; set; }

        /// <summary>
        /// User agent of recipient. Present only if detected for “clicked” and “opened” statuses
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// Recipient’s IP address. Present only if detected for “clicked” and “opened” statuses
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }
    }
}
