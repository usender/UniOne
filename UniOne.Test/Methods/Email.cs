using System.Collections.Generic;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Email;

namespace Sender.UniOne.Test.Methods
{
    public class Email : BaseMethod
    {
        public static Data<EmailMessage, MessageResponse> Send()
        {
            var request = new EmailMessage
            {
                Attachments = new List<Attachment>(),

                Body = new MessageBody
                {
                    Plaintext = "some message"
                }
            };

            var response = new MessageResponse
            {
                Emails = new[] { "test@email.com" },
                JobId = "11-abs-22",
                FailedEmails = new Dictionary<string, string>()
                {
                    {"qaz@email.com", "temporary_unavailable"},
                    {"zxc@email.com", "permanent_unavailable"}
                }
            };

            return Send(request, response);
        }
    }
}