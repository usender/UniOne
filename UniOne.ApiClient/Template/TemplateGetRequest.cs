using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateGetRequest : BaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Template.Get;

        public TemplateGetRequest(string id)
        {
            Id = id;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
