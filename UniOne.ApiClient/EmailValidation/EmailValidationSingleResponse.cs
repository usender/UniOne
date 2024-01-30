using System;
using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.EmailValidation
{
    public class EmailValidationSingleResponse : BaseResponse
    {
        /// <summary>
        /// Email address to be checked.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; internal set; }

        /// <summary>
        /// Possible statuses: <see cref="http://docs.unione.io/en/web-api-ref?csharp#email-validation-single"/>
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; internal set; }

        /// <summary>
        /// Possible statuses: <see cref="http://docs.unione.io/en/web-api-ref?csharp#email-validation-single"/>
        /// </summary>
        [JsonProperty("cause")]
        public string Cause { get; internal set; }

        /// <summary>
        /// Validity score, from 0 to 100 (0 – invalid, 100 – valid).
        /// </summary>
        [JsonProperty("validity")]
        public int Validity { get; internal set; }

        /// <summary>
        /// Local part (everything preceding the @ sign).
        /// </summary>
        [JsonProperty("local_part")]
        public string LocalPart { get; internal set; }

        /// <summary>
        /// Domain name part.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; internal set; }

        /// <summary>
        /// True if the address’ domain does have an MX record, false if does not.
        /// </summary>
        [JsonProperty("mx_found")]
        public bool MxFound { get; internal set; }

        /// <summary>
        /// Preferred MX record for the domain.
        /// </summary>
        [JsonProperty("mx_record")]
        public string MxRecord { get; internal set; }

        /// <summary>
        /// For addresses which are likely to have typing errors (cause=possible_typo), a suggested variant with a fixed typo.
        /// </summary>
        [JsonProperty("did_you_mean")]
        public string DidYouMean { get; internal set; }

        /// <summary>
        /// Email check date and time, YYYY-MM-DD hh:mm:ss UTC.
        /// </summary>
        [JsonProperty("processed_at")]
        public DateTime ProcessedAt { get; internal set; }
    }
}