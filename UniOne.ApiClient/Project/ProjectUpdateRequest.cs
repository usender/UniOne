using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Project
{
    internal class ProjectUpdateRequest : ProjectIdentifierRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Project.Update;

        public ProjectUpdateRequest(ProjectIdentifier identifier, ProjectInfo project) 
            : base(identifier)
        {
            Project = project;
        }

        /// <summary>
        /// Object with project properties
        /// </summary>
        [JsonProperty("project")]
        public ProjectInfo Project { get; set; }
    }
}
