using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Domain
{
    public class ValidateDkimResponse : BaseResponse
    {
        /// <summary>
        /// Debug message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
