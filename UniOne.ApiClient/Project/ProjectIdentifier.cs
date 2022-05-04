using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectIdentifier
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_api_key")]
        public string ProjectApiKey { get; set; }
    }
}
