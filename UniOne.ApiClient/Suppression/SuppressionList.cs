using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Sender.UniOne.ApiClient.Suppression
{
    public class SuppressionList
    {
        /// <summary>
        /// Email to get suppression details fo
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; internal set; }

        /// <summary>
        /// Cause of email being suppressed. One of
        /// </summary>
        [JsonProperty("cause", ItemConverterType = typeof(StringEnumConverter))]
        public SuppressionCause Cause { get; internal set; }

        /// <summary>
        /// Is it possible to delete this suppression by calling suppression/delete method
        /// </summary>
        [JsonProperty("is_deletable")]
        public bool IsDeletable { get; internal set; }

        /// <summary>
        /// When suppression was created, in UTC timezone
        /// </summary>
        [JsonProperty("created")]
        public DateTime CreatedDateUtc { get; internal set; }
    }
}
