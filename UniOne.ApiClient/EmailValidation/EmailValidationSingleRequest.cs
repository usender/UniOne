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

        public string Email { get; set; }
    }
}
