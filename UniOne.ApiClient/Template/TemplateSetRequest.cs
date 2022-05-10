using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateSetRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Template.Set;

        public TemplateSetRequest(TemplateMessage template)
        {
            Template = template;
        }

        [JsonProperty("template")]
        public TemplateMessage Template { get; set; }
    }
}