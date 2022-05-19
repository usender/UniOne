﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Attributes;

namespace Sender.UniOne.ApiClient.Webhook
{
    internal abstract class WebhookBaseRequest : BaseRequest
    {
        protected WebhookBaseRequest(string url)
        {
            Url = url;
        }

        /// <summary>
        /// URL that will receive the notification when an event occurs
        /// </summary>
        [Required]
        [UrlValidation]
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
