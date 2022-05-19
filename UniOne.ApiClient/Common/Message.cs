using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Sender.UniOne.ApiClient.Email;
using Sender.UniOne.ApiClient.Infrastructure.JsonConverters;

namespace Sender.UniOne.ApiClient.Common
{
    public class Message
    {
        /// <summary>
        /// Undocumented required parameter
        /// </summary>
        [JsonProperty("template_engine")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateEngineEnum TemplateEngine { get; set; }

        /// <summary>
        /// Object, contains html and plaintext parts of the email
        /// </summary>
        [JsonProperty("body")]
        [Required]
        public MessageBody Body { get; set; }

        /// <summary>
        /// Sender’s email
        /// </summary>
        [JsonProperty("from_email")]
        [EmailAddress]
        [Required(AllowEmptyStrings = true)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Undocumented required parameter
        /// </summary>
        [JsonProperty("from_name")]
        [Required(AllowEmptyStrings = true)]
        public string FromName { get; set; }

        /// <summary>
        /// 0 - the click tracking is off
        /// 1 - the click tracking is on
        /// default: 1
        /// </summary>
        [JsonProperty("track_links")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool TrackLinks { get; set; }

        /// <summary>
        /// 0 - the email read tracking is off
        /// 1 - the email read tracking is on
        /// default: 1
        /// </summary>
        [JsonProperty("track_read")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool TrackRead { get; set; }

        /// <summary>
        ///  Optional string. Email subject
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Optional Reply-To email (in case it’s different to sender’s email)
        /// </summary>
        [JsonProperty("reply_to")]
        [Required(AllowEmptyStrings = true)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Optional object
        /// Object to pass the substitutions(merge tags) for the recipient (e.g. recipient name, discount code, password change link, etc. See <see cref="http://docs.unione.io/template-engines"/> Template engines). The substitutions can be used in the following parameters:
        /// </summary>
        [JsonProperty("global_substitutions")]
        public Substitution GlobalSubstitutions { get; set; }

        /// <summary>
        /// Optional  object
        /// Object for passing the metadata, such as “key”: “value”. Max key quantity: 10. Max key length: 64 symbols. Max value length: 1024 symbols. The metadata is returned by <see cref="http://docs.unione.io/en/web-api-ref?csharp#webhook"/>.
        /// </summary>
        [JsonProperty("global_metadata")]
        public Metadata GlobalMetadata { get; set; }

        /// <summary>
        /// For detail <seealso cref="http://www.mkyong.com/computer-tips/different-between-inline-and-attachment-in-email"/>
        /// </summary>
        [JsonProperty("attachments")]
        public ICollection<Attachment> Attachments { get; set; }

        /// <summary>
        /// For detail <seealso cref="http://www.mkyong.com/computer-tips/different-between-inline-and-attachment-in-email"/>
        /// </summary>
        [JsonProperty("inline_attachments")]
        public ICollection<Attachment> InlineAttachments { get; set; }

        /// <summary>
        /// Contains email headers, maximum 50. Only headers with “X-” name prefix are accepted, all other are ignored, for example X-UNIONE-Global-Language, X-UNIONE-Template-Engine. If our support have approved omitting standard unsubscription block for you, you can also pass List-Unsubscribe, List-Subscribe, List-Help, List-Owner and List-Archive headers
        /// </summary>
        [JsonProperty("headers")]
        public Header Headers { get; set; }
    }
}
