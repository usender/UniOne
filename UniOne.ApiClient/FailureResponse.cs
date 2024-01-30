using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient
{
    /// <summary>
    /// Failure response
    /// </summary>
    public class FailureResponse
    {
        internal FailureResponse()
        {

        }

        internal FailureResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }

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

        /// <summary>
        /// Indicated if the message set from validation when parameter <see cref="UniOneSettings.IsNeedValidatingRequestBeforeSending"/> set to true
        /// </summary>
        [JsonProperty("is_client_validation")]
        public bool IsClientValidation { get; internal set; }
    }
}
