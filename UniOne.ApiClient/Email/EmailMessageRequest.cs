using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// Uni sender configuration request
    /// For detail <see cref="http://eu1.unione.io/en/docs/page/email_send_v1"/>
    /// </summary>
    internal class EmailMessageRequest : BaseRequest
    {
        public EmailMessageRequest(EmailMessage message)
        {
            Message = message;
        }

        internal override ApiAction ApiAction => ApiAction.Email.Send;

        /// <summary>
        /// Object, contains the parameters of the message
        /// </summary>
        [JsonProperty("message")]
        public EmailMessage Message { get; set; }
    }
}