using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateListResponse : BaseResponse
    {
        [JsonProperty("templates")]
        public TemplateLMessageView[] Templates { get; set; }
    }
}