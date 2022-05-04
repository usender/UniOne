using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Common
{
    /// <summary>
    /// Contains HTML/plaintext/AMP parts of the email. Either html or plaintext part is required.
    /// Required, if template_id is not passed.
    /// </summary>
    public class MessageBody
    {
        /// <summary>
        /// Body type
        /// </summary>
        public enum Type
        {
            Auto,
            Html,
            Plaintext,
            Amp
        }

        /// <summary>
        /// Html part of the letter body
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Plaintext part of the letter body
        /// </summary>
        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        /// <summary>
        /// Optional AMP part of the email body
        /// </summary>
        [JsonProperty("amp")]
        public string Amp { get; set; }

        public void SetBody(string emailBody, Type type = Type.Auto)
        {
            switch (type)
            {
                case Type.Auto:
                    // check if email body contains any HTML tags
                    if (Regex.IsMatch(emailBody, "<(.|\n)*?>"))
                    {
                        Html = emailBody;
                    }
                    else
                    {
                        Plaintext = emailBody;
                    }
                    break;
                case Type.Amp:
                    Amp = emailBody;
                    break;
                case Type.Html:
                    Html = emailBody;
                    break;
                case Type.Plaintext:
                    Plaintext = emailBody;
                    break;
            }
        }
    }
}