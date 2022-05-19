using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient
{
    public enum Language
    {
        [EnumMember(Value = "en")]
        English,

        [EnumMember(Value = "ru")]
        Russian
    }
}
