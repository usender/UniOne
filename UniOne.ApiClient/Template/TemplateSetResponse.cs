using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateSetResponse : BaseResponse
    {
        [JsonProperty("template")]
        public TemplateMessage Template { get; set; }
    }
}
