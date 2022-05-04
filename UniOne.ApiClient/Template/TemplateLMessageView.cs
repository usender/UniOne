using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateLMessageView : TemplateMessage
    {
        [JsonProperty("created")]
        public DateTime CreatedDateUtc { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }
    }
}
