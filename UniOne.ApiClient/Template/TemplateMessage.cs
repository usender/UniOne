using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateMessage : Message
    {
        public TemplateMessage()
        {
            Body = new MessageBody();
        }

        [Required]
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("editor_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateMessageEditorType? EditorType { get; set; }
    }
}
