namespace Sender.UniOne.ApiClient.Apis
{
    internal class EmailEndpoint : ApiEndpoint
    {
        internal EmailEndpoint()
            : base("email")
        {
        }

        internal ApiEndpoint Send => Path("send.json");

        internal ApiEndpoint Subscribe => Path("subscribe.json");
    }
}
