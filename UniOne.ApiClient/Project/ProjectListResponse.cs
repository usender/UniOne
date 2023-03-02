using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectListResponse : BaseResponse
    {
        [JsonProperty("projects")]
        public ProjectItem[] Projects { get; internal set; }
    }
}
