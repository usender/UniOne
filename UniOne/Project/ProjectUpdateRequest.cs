﻿using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Project
{
    internal class ProjectUpdateRequest : ProjectIdentifierRequest
    {
        internal override ApiAction ApiAction => ApiAction.Project.Update;

        public ProjectUpdateRequest(ProjectIdentifier identifier, ProjectInfo project) 
            : base(identifier)
        {
            Project = project;
        }

        [JsonProperty("project")]
        public ProjectInfo Project { get; set; }
    }
}
