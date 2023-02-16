using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Template.Delete;

        internal TemplateDeleteRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Template id
        /// </summary>
        [Required]
        [JsonProperty("id")]
        internal string Id { get; set; }
    }
}
