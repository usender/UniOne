using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Project
{
    /// <summary>
    /// Object with project properties
    /// </summary>
    public class ProjectInfo
    {
        /// <summary>
        /// Project name, unique for user account.
        /// </summary>
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ISO-3166 alpha-2 country code. If set, UniOne treats project personal data according to country laws, e.g. GDPR for european countries.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Whether email sending is enabled for this project or not.
        /// </summary>
        [JsonProperty("send_enabled")]
        public bool? SendEnabled { get; set; }

        /// <summary>
        /// If it’s false then UniOne adds default unsubscribe footer to each email sent with API key of the project. If it’s true then appending default unsubscribe footer for this project is avoided and sending with custom unsubscribe url or even without unsubscribe url is permitted for the project. Please note that custom_unsubscribe_url_enabled=true is available only if removing unsubscribe link is approved for the user account by support. More on this <see cref="http://docs.unione.io/unsubscribe-link"/>. When custom_unsubscribe_url_enabled is skipped on creating a project, it’s value is taken from user
        /// <seealso cref="http://docs.unione.io/en/web-api-ref?csharp#project-create"/>
        /// </summary>
        [JsonProperty("custom_unsubscribe_url_enabled")]
        public bool? CustomUnsubscribeUrlEnabled { get; set; }
    }
}
