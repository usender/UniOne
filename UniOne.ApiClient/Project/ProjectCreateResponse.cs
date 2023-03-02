using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectCreateResponse : BaseResponse
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; internal set; }

        [JsonProperty("project_api_key")]
        public string ProjectApiKey { get; internal set; }
    }
}