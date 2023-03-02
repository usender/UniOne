using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateSetRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Template.Set;

        public TemplateSetRequest(TemplateMessage template)
        {
            Template = template;
        }

        /// <summary>
        /// Object with all the template properties.
        /// </summary>
        [Required]
        [JsonProperty("template")]
        public TemplateMessage Template { get; set; }
    }
}