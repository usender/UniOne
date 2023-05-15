namespace Sender.UniOne.ApiClient.Apis
{
    internal class EmailValidationEndpoints : ApiEndpoint
    {
        internal EmailValidationEndpoints()
            : base("email-validation")
        { }

        internal ApiEndpoint Single => Combine("single.json");
    }
}
