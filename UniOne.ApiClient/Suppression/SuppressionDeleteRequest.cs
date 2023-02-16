using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Suppression
{
    internal class SuppressionDeleteRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Suppression.Delete;

        /// <summary>
        /// An email to delete from suppression list
        /// </summary>
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
