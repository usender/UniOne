using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateDeleteRequest : BaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Template.Delete;

        public TemplateDeleteRequest(string id)
        {
            Id = id;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
