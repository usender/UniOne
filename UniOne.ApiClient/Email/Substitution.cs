using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Email
{
    public class Substitution
    {
        /// <summary>
        /// Property use in message body. Use as {{to_name}}
        /// There’s a special substitution “to_name” which is used to put recipent’s name like “Name Surname” to include it to SMTP header “To” in the form “Name Surname <email@example.com>”
        /// </summary>
        [JsonProperty("to_name")]
        [MaxLength(78)]
        public string ToName { get; set; }
    }
}