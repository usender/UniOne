using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateSetRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Template.Set;

        public TemplateSetRequest(TemplateMessage template)
        {
            Template = template;
        }

        [Required]
        [JsonProperty("template")]
        public TemplateMessage Template { get; set; }
    }
}