using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateGetRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Template.Get;

        public TemplateGetRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Template id
        /// </summary>
        [Required]
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
