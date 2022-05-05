using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectIdentifier
    {
        /// <summary>
        /// Optional possibility to specify project_id to include only this project to list
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Optional possibility to specify project_api_key to include only this project to list
        /// </summary>
        public string ProjectApiKey { get; set; }
    }
}
