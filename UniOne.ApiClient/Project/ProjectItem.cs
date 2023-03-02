using Newtonsoft.Json;
using System;

namespace Sender.UniOne.ApiClient.Project
{
    public class ProjectItem
    {
        /// <summary>
        /// Unique project identifier, ASCII string up to 36 characters long
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// API key of the project. You can use it instead of the user API key parameter in all methods except project/* methods
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey { get; internal set; }

        /// <summary>
        /// Project name, unique for user account
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }

        /// <summary>
        /// ISO-3166 alpha-2 country code. If set, UniOne treats project personal data according to country laws, e.g. GDPR for european countries
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; internal set; }

        /// <summary>
        /// Date and time of project creation in UTC timezone in “YYYY-MM-DD hh:mm:ss” format
        /// </summary>
        [JsonProperty("reg_time")]
        public DateTime CreatedDate { get; internal set; }

        /// <summary>
        /// Whether email sending is enabled for this project or not
        /// </summary>
        [JsonProperty("send_enabled")]
        public bool? SendEnabled { get; internal set; }

        /// <summary>
        /// If it’s false then UniOne adds default unsubscribe footer to each email sent with API key of the project. If it’s true then appending default unsubscribe footer for this project is avoided and sending with custom unsubscribe url or even without unsubscribe url is permitted for the project. Please note that custom_unsubscribe_url_enabled=true is available only if removing unsubscribe link is approved for the user account by support. More on this here. When custom_unsubscribe_url_enabled is skipped on creating a project, it’s value is taken from user
        /// </summary>
        [JsonProperty("custom_unsubscribe_url_enabled")]
        public bool? CustomUnsubscribeUrlEnabled { get; internal set; }

        /// <summary>
        /// A unique domain identifier which will determine the tracking domain or dedicated IP pool to be used by default. If the value is not specified, a default system backend domain will be assigned for our account or project instead
        /// </summary>
        [JsonProperty("backend_id")]
        public int BackendId { get; internal set; }
    }
}
