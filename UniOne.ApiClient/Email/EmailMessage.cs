using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Infrastructure.JsonConverters;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// Object, contains the parameters of the message
    /// </summary>
    public class EmailMessage : Message
    {
        public EmailMessage()
        {
            Body = new MessageBody();
            Tags = new List<string>();
            Recipients = new List<Recipient>();
            Attachments = new List<Attachment>();
            InlineAttachments = new List<Attachment>();
            TemplateEngine = TemplateEngine.Simple;
        }

        /// <summary>
        /// Optional identifier of the template that had been created by template/set method
        /// </summary>
        [JsonProperty("template_id")]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// An array of strings. The maximum string length is 50 characters. You can include up to 4 strings which must be unique. No more than 10 000 tags are allowed per project; if you try to add more, email/send will return an error. You may use tags to categorize emails by your own criteria, and they will be passed along by event-dump methods
        /// </summary>
        [JsonProperty("tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Whether to skip or not appending default unsubscribe footer. 1=skip, 0=append, default is 0. You should ask support to approve
        /// </summary>
        [JsonProperty("skip_unsubscribe")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool SkipUnsubscribed { get; set; }

        /// <summary>
        /// The language of the unsubscribe footer and unsubscribe page. Languages supported “ru”, “en”, “ua”, “be”, “es”, “fr”, “pl”, “de”, “pt”, “it”.
        /// </summary>
        [JsonProperty("global_language")]
        public string GlobalLanguage { get; set; }

        /// <summary>
        /// List of objects that contains recipients’ emails
        /// Maximum number of recipients is 500
        /// </summary>
        [JsonProperty("recipients")]
        [Required]
        public IList<Recipient> Recipients { get; set; }

        /// <summary>
        /// Optional object. Additional message options.
        /// </summary>
        [JsonProperty("options")]
        public MessageOptions Options { get; set; }
    }
}