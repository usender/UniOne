using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// Recipient object
    /// </summary>
    public class Recipient
    {
        public Recipient()
            : this(null)
        {

        }

        public Recipient(string email)
        {
            Email = email;
        }

        /// <summary>
        /// Recipient email
        /// </summary>
        ///         [Required]
        [EmailAddress]
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional object
        /// Object to pass the substitutions(merge tags) for the recipient (e.g. recipient name, discount code, password change link, etc. See <see cref="http://docs.unione.io/template-engines"/> Template engines). The substitutions can be used in the following parameters:
        /// </summary>
        [JsonProperty("substitutions")]
        public Substitution Substitutions { get; set; }

        /// <summary>
        /// Optional  object
        /// Object for passing the metadata, such as “key”: “value”. Max key quantity: 10. Max key length: 64 symbols. Max value length: 1024 symbols. The metadata is returned by <see cref="http://docs.unione.io/en/web-api-ref?csharp#webhook"/>.
        /// </summary>
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
