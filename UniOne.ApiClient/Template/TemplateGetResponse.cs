using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateGetResponse : BaseResponse
    {
        [JsonProperty("template")]
        public TemplateMessage Template { get; set; }
    }
}
