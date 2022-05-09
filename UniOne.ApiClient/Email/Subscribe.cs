namespace Sender.UniOne.ApiClient.Email
{
    public class Subscribe
    {
        /// <summary>
        /// Sender’s email. (Field alias “email_address_from” is supported, too).
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Sender’s name. (Field alias “name_from” is supported, too).
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// Recipient’s email. (Field alias “email_address_to” is supported, too).
        /// </summary>
        public string ToEmail { get; set; }
    }
}