using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    internal abstract class ProjectIdentifierRequest : BaseRequest
    {
        protected ProjectIdentifierRequest(ProjectIdentifier project)
        {
            ProjectId = project.ProjectId;
            ProjectApiKey = project.ProjectApiKey;
        }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_api_key")]
        public string ProjectApiKey { get; set; }
    }
}
