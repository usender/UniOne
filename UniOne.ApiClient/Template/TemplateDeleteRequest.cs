using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Template.Delete;

        public TemplateDeleteRequest(string id)
        {
            Id = id;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
