using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient
{
    /// <summary>
    /// Failure response
    /// </summary>
    public class FailureResponse
    {
        /// <summary>
        /// <see cref="http://docs.unione.io/ru/web-api-ref?csharp#api-errors"/>
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; internal set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; internal set; }
    }
}
