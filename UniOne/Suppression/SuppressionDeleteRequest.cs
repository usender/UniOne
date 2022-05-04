﻿using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Suppression
{
    internal class SuppressionDeleteRequest : BaseRequest
    {
        internal override ApiAction ApiAction => ApiAction.Suppression.Delete;

        /// <summary>
        /// An email to delete from suppression list
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
