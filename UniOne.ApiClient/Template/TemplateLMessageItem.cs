using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateLMessageItem : TemplateMessage
    {
        [JsonProperty("created")]
        public DateTime CreatedDateUtc { get; internal set; }

        [JsonProperty("user_id")]
        public int UserId { get; internal set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; internal set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; internal set; }
    }
}