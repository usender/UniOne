using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Webhook.Models
{
    public class UserEvent
    {
        /// <summary>
        /// Unique user identifier
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Project identifier, present only if webhook was registered for the project using project API key
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Project name, present only if webhook was registered for the project using project API key
        /// </summary>
        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// Array of events reported by webhook
        /// </summary>
        [JsonProperty("events")]
        public EventInfo[] Events { get; set; }
    }
}
