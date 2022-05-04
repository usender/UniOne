using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public enum WebhookEventFormat
    {
        [EnumMember(Value = "json_post")]
        JsonPost,

        [EnumMember(Value = "json_post_gzip")]
        JsonPostGzip
    }
}
