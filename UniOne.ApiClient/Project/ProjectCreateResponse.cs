using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectCreateResponse : ProjectUpdateResponse
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; internal set; }
    }
}
