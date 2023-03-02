using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateGetResponse : BaseResponse
    {
        /// <summary>
        /// Object with all the template properties
        /// </summary>
        [JsonProperty("template")]
        public TemplateMessage Template { get; internal set; }
    }
}
