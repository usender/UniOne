using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Suppression
{
    internal class SuppressionGetRequest : BaseRequest
    {
        /// <summary>
        /// Email to get suppression details for
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// If a user has projects functionality enabled, he/she can pass all_projects=true to search in all projects’ data.
        /// </summary>
        [JsonProperty("all_projects")]
        public bool AllProjects { get; set; }

        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Suppression.Get;
    }
}
