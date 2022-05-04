namespace Sender.UniOne.ApiClient.Apis
{
    internal class DomainAction : ApiAction
    {
        internal DomainAction()
            : base("domain")
        { }

        internal ApiAction GetDnsRecords => Path("get-dns-records.json");

        internal ApiAction ValidateVerificationRecord => Path("validate-verification-record.json");

        internal ApiAction ValidateDkim => Path("validate-dkim.json");

        internal ApiAction List => Path("list.json");
    }
}
