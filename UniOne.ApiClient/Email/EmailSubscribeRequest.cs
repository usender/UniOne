using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Email
{
    internal class EmailSubscribeRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Email.Subscribe;

        internal EmailSubscribeRequest(Subscribe subscribe)
        {
            FromEmail = subscribe.FromEmail;
            FromName = subscribe.FromName;
            ToEmail = subscribe.ToEmail;
        }

        /// <summary>
        /// Sender’s email. (Field alias “email_address_from” is supported, too).
        /// </summary>
        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        /// <summary>
        /// Sender’s name. (Field alias “name_from” is supported, too).
        /// </summary>
        [JsonProperty("from_name")]
        public string FromName { get; set; }

        /// <summary>
        /// Recipient’s email. (Field alias “email_address_to” is supported, too).
        /// </summary>
        [JsonProperty("to_email")]
        public string ToEmail { get; set; }
    }
}
