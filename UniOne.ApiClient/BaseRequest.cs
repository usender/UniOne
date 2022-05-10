using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Infrastructure.Exceptions;
using Sender.UniOne.ApiClient.Infrastructure.Extensions;

namespace Sender.UniOne.ApiClient
{
    internal abstract class BaseRequest
    {
        /// <summary>
        /// API end part of endpoint
        /// </summary>
        internal abstract ApiEndpoint ApiEndpoint { get; }

        /// <summary>
        /// Key to access the API
        /// </summary>
        [JsonProperty("api_key")]
        internal string ApiKey { get; set; }

        /// <summary>
        /// Returns a string that represents the current object as JSON
        /// </summary>
        public override string ToString()
        {
            return this.ToJson();
        }

        protected internal virtual void Validate()
        {
            if(string.IsNullOrWhiteSpace(ApiKey))
                throw new UniOneClientValidationException("Invalid api key");

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);

            if (!Validator.TryValidateObject(this, context, results, true))
            {
                throw new UniOneClientValidationException(results[0].ErrorMessage);
            }
        }
    }
}