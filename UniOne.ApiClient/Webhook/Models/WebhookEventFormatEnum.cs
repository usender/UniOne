using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    /// <summary>
    /// Notification format
    /// </summary>
    public enum WebhookEventFormat
    {
        /// <summary>
        /// Json post
        /// </summary>
        [EnumMember(Value = "json_post")]
        JsonPost,

        /// <summary>
        /// Json post gzip
        /// </summary>
        [EnumMember(Value = "json_post_gzip")]
        JsonPostGzip
    }
}