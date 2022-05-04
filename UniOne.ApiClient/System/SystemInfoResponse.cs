using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.System
{
    public class SystemInfoResponse : BaseResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("accounting")]
        public Accounting Accounting { get; set; }
    }
}
