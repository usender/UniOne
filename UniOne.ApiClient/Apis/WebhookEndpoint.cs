namespace Sender.UniOne.ApiClient.Apis
{
    internal class WebhookEndpoint : ApiEndpoint
    {
        internal WebhookEndpoint() 
            : base("webhook")
        { }

        internal ApiEndpoint Set => Combine("set.json");

        internal ApiEndpoint Get => Combine("get.json");

        internal ApiEndpoint Delete => Combine("delete.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}