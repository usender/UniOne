using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal abstract class UnsubscribedBaseRequest : BaseRequest
    {
        protected UnsubscribedBaseRequest(string email)
        {
            EmailAddress = email;
        }

        /// <summary>
        /// Email address to unsubscribed or check
        /// </summary>
        [Required]
        [JsonProperty("address")]
        public string EmailAddress { get; set; }
    }
}
