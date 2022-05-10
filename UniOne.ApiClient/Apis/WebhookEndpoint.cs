namespace Sender.UniOne.ApiClient.Apis
{
    internal class WebhookEndpoint : ApiEndpoint
    {
        internal WebhookEndpoint() 
            : base("webhook")
        { }

        internal ApiEndpoint Set => Path("set.json");

        internal ApiEndpoint Get => Path("get.json");

        internal ApiEndpoint Delete => Path("delete.json");

        internal ApiEndpoint List => Path("list.json");
    }
}