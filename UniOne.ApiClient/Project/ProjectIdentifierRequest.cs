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

        /// <summary>
        /// Optional possibility to specify project_id to include only this project to list
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Optional possibility to specify project_api_key to include only this project to list
        /// </summary>
        [JsonProperty("project_api_key")]
        public string ProjectApiKey { get; set; }
    }
}