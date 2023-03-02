using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Common
{
    public enum TemplateEngine
    {
        [EnumMember(Value = "none")]
        None,

        [EnumMember(Value = "simple")]
        Simple,

        [EnumMember(Value = "velocity")]
        Velocity
    }
}
