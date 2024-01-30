namespace Sender.UniOne.ApiClient.Apis
{
    internal class DomainEndpoint : ApiEndpoint
    {
        internal DomainEndpoint()
            : base("domain")
        { }

        internal ApiEndpoint GetDnsRecords => Combine("get-dns-records.json");

        internal ApiEndpoint ValidateVerificationRecord => Combine("validate-verification-record.json");

        internal ApiEndpoint ValidateDkim => Combine("validate-dkim.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}
