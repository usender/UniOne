using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.System
{
    public class SystemInfoResponse : BaseResponse
    {
        /// <summary>
        /// Unique user identifier
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; internal set; }

        /// <summary>
        /// Email of the user
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; internal set; }

        /// <summary>
        /// Unique project identifier, ASCII string up to 36 characters long. Present only if the API key used for request is the project API key.
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; internal set; }

        /// <summary>
        /// Project name, unique for user account. Present only if the API key used for request is the project API key
        /// </summary>
        [JsonProperty("project_name")]
        public string ProjectName { get; internal set; }

        /// <summary>
        /// Object with accounting period properties. Present only if the API key used for request is the user API key
        /// </summary>
        [JsonProperty("accounting")]
        public Accounting Accounting { get; internal set; }
    }
}
