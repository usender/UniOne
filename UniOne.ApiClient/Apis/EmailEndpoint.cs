namespace Sender.UniOne.ApiClient.Apis
{
    internal class EmailEndpoint : ApiEndpoint
    {
        internal EmailEndpoint()
            : base("email")
        {
        }

        internal ApiEndpoint Send => Combine("send.json");

        internal ApiEndpoint Subscribe => Combine("subscribe.json");
    }
}
