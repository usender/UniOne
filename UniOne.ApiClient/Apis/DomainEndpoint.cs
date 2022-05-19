namespace Sender.UniOne.ApiClient.Apis
{
    internal class DomainEndpoint : ApiEndpoint
    {
        internal DomainEndpoint()
            : base("domain")
        { }

        internal ApiEndpoint GetDnsRecords => Path("get-dns-records.json");

        internal ApiEndpoint ValidateVerificationRecord => Path("validate-verification-record.json");

        internal ApiEndpoint ValidateDkim => Path("validate-dkim.json");

        internal ApiEndpoint List => Path("list.json");
    }
}
