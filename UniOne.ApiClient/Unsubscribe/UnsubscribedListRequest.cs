using System;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Infrastructure.JsonConverters;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal class UnsubscribedListRequest : BaseRequest
    {
        internal override ApiEndpoint ApiEndpoint => ApiEndpoint.Unsubscribed.List;

        internal UnsubscribedListRequest(DateTime dateFrom)
        {
            DateFromUtc = dateFrom;
        }

        /// <summary>
        /// Date in the format YYYY-MM-DD to get all unsubscribed emails from the “date_from” to the present day. If the parameter is not specified, the default period is today (from 00:00 UTC).
        /// </summary>
        [JsonProperty("date_from")]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? DateFromUtc { get; set; }
    }
}
