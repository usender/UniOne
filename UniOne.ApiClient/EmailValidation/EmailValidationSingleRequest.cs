using System.ComponentModel.DataAnnotations;
using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.EmailValidation
{
    internal class EmailValidationSingleRequest : BaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.EmailValidation.Single;

        internal EmailValidationSingleRequest(string email)
        {
            Email = email;
        }
        /// <summary>
        /// Email address to be checked
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
    }
}
