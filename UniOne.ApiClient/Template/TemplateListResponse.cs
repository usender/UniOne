using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Template
{
    public class TemplateListResponse : BaseResponse
    {
        /// <summary>
        /// Array of template objects
        /// </summary>
        [JsonProperty("templates")]
        public TemplateLMessageItem[] Templates { get; internal set; }
    }
}