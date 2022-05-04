using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Project
{
    internal class ProjectCreateRequest : BaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Project.Create;

        public ProjectCreateRequest(ProjectInfo project)
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
