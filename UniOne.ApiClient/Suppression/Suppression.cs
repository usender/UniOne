using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Suppression
{
    public class Suppression
    {
        /// <summary>
        /// Unique project identifier, ASCII string up to 36 characters long
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Cause of email being suppressed. One of
        /// </summary>
        [JsonProperty("cause")]
        public string Cause { get; set; }

        /// <summary>
        /// Is it possible to delete this suppression by calling suppression/delete method
        /// </summary>
        [JsonProperty("is_deletable")]
        public bool IsDeletable { get; set; }

        /// <summary>
        /// When suppression was created, in UTC timezone
        /// </summary>
        [JsonProperty("created")]
        public DateTime CreatedDateUtc { get; set; }
    }
}