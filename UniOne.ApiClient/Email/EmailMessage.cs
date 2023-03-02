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

        /// <summary>
        /// Default value false. If set to true, the global unavailability list will be ignored. Even if the address was found to be unreachable while sending other UniOne users’ emails, or its owner has issued complaints, the message will still be sent. The setting may be ignored for certain addresses
        /// </summary>
        [JsonProperty("bypass_global")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool BypassGlobal { get; set; }

        /// <summary>
        /// If set to true, the current user’s or project’s unavailability list will be ignored. Works only if bypass_global is set to true
        /// </summary>
        [JsonProperty("bypass_unavailable")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool BypassUnavailable { get; set; }

        /// <summary>
        ///  Default value false. If set to true, the current list of unsubscribed addresses for this account or project will be ignored. Works only if bypass_global is set to 1. The setting is available only for users that have been granted the right to omit the unsubscribe link
        /// </summary>
        [JsonProperty("bypass_unsubscribed")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool BypassUnsubscribed { get; set; }

        /// <summary>
        /// Default value false. If set to true, the user’s or project’s complaint list will be ignored. Works only if bypass_global is set to true.
        /// </summary>
        [JsonProperty("bypass_complained")]
        [JsonConverter(typeof(IntToBoolConverter))]
        public bool BypassComplained { get; set; }
    }
}