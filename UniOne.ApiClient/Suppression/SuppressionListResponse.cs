using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Suppression
{
    public class SuppressionListResponse : BaseResponse
    {
        /// <summary>
        /// Suppression objects
        /// </summary>
        [JsonProperty("suppressions")]
        public Suppression[] Suppressions { get; internal set; }

        /// <summary>
        /// The parameter indicates from which position the selection is to be started. Must be empty or omitted for the first data chunk. In order to get subsequent chunks, you must set the “cursor” parameter in your request, using the value received in response to the previous request.
        /// </summary>
        [JsonProperty("cursor")]
        public string Cursor { get; internal set; }
    }
}
