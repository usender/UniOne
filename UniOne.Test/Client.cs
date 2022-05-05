using Sender.UniOne.ApiClient;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Email;
using System.Linq;
using System.Threading.Tasks;
using Sender.UniOne.ApiClient.System;

namespace Sender.UniOne.Test
{
    public class Client
    {
        private readonly UniOneClient _uniOneClient;

        public Client(UniOneSettings settings)
        {
            _uniOneClient = new UniOneClient(settings);
        }

        public Task<EmailMessageResponse> EmailSendAsync(string fromEmail, string[] toEmails)
        {
            var emailMessage = new EmailMessage
            {
                Subject = "uni one client",
                FromName = "user company",
                FromEmail = fromEmail,
                Recipients = toEmails.Select(email => new Recipient(email)
                {
                    Substitutions = new Substitution
                    {
                        ToName = email.Split('@')[0]
                    }
                }).ToList(),
                Body = new MessageBody
                {
                    Plaintext = "Example message for {{to_name}}."
                }
            };

            return _uniOneClient.EmailSendAsync(emailMessage);
        }

        public Task<SystemInfoResponse> SystemInfo()
        {
            return _uniOneClient.SystemInfoAsync();
        }
    }
}