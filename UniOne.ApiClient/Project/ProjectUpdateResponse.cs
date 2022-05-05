using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectUpdateResponse : BaseResponse
    {
        [JsonProperty("project_api_key")]
        public string ProjectApiKey { get; internal set; }
    }
}
