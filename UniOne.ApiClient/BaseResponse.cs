using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient
{
    public class BaseResponse
    {
        internal const string STATUS_SUCCESS = "success";
        internal const string STATUS_ERROR = "error";

        private FailureResponse _failureResponse;

        /// <summary>
        /// Display the response status. True if success, otherwise false
        /// </summary>
        public bool IsSuccess => Status == STATUS_SUCCESS;

        /// <summary>
        /// Uni one response status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; internal set; }

        /// <summary>
        /// Failure response. Null when status is "success" or property IsSuccess is true, otherwise see object data>
        /// </summary>
        public FailureResponse Failure
        {
            get => _failureResponse;
            internal set
            {
                _failureResponse = value;
                Status = STATUS_ERROR;
            }
        }
    }
}
