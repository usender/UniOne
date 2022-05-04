﻿using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Suppression
{
    public class SuppressionGetResponse : BaseResponse
    {
        /// <summary>
        /// The email for which suppression details were requested
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Array of suppression objects
        /// </summary>
        [JsonProperty("suppression")]
        public Suppression Suppression { get; set; }
    }
}
