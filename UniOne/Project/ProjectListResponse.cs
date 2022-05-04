using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectListResponse : BaseResponse
    {
        [JsonProperty("projects")]
        public ProjectView[] Projects { get; set; }
    }
}
