using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public enum WebhookStatus
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "disabled")]
        Disabled,

        [EnumMember(Value = "stopped")]
        Stopped
    }
}
