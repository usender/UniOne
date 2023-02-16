using System;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace Sender.UniOne.ApiClient.Suppression
{
    internal class SuppressionSetRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Suppression.Set;

        /// <summary>
        /// Email to add in suppression list
        /// </summary>
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Cause of email being suppressed. One of: unsubscribed, temporary_unavailable, permanent_unavailable, complained 
        /// </summary>
        [JsonProperty("cause", ItemConverterType = typeof(StringEnumConverter))]
        public SuppressionCause? Cause { get; set; }

        /// <summary>
        /// When suppression was created, in UTC timezone in “YYYY-MM-DD hh:mm:ss” format.
        /// </summary>
        [JsonProperty("created")]
        public DateTime? Created { get; set; }
    }
}
