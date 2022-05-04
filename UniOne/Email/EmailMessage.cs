using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Common;

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
            Recipients = new List<Recipient>();
            Attachments = new List<Attachment>();
            InlineAttachments = new List<Attachment>();
            TemplateEngine = TemplateEngineEnum.Simple;
        }

        /// <summary>
        /// Optional identifier of the template that had been created by template/set method
        /// </summary>
        [JsonProperty("template_id")]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// List of objects that contains recipients’ emails
        /// Maximum number of recipients is 500
        /// </summary>
        [JsonProperty("recipients")]
        [Required]

        public ICollection<Recipient> Recipients { get; set; }

        /// <summary>
        /// Optional object. Additional message options.
        /// </summary>
        [JsonProperty("options")]
        public MessageOptions Options { get; set; }
    }
}