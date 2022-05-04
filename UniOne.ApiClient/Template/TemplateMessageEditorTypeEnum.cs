using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Template
{
    public enum TemplateMessageEditorType
    {
        [EnumMember(Value = "html")]
        Html,

        [EnumMember(Value = "visual")]
        Visual
    }
}
