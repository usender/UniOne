using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using System.Collections.Generic;

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

        internal override ApiEndpoint Endpoint => ApiEndpoint.Email.Send;

        /// <summary>
        /// Object, contains the parameters of the message
        /// </summary>
        [JsonProperty("message")]
        public EmailMessage Message { get; set; }
        
        protected internal override List<string> Validate()
        {
           var errors = base.Validate();

            if (Message.Recipients.Count > 500)
            {
                errors.Add("Maximum number of recipients is 500");
            }

            return errors;
        }
    }
}