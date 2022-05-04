namespace Sender.UniOne.ApiClient.Apis
{
    internal class WebhookAction : ApiAction
    {
        internal WebhookAction() 
            : base("webhook")
        { }

        internal ApiAction Set => Path("set.json");

        internal ApiAction Get => Path("get.json");

        internal ApiAction Delete => Path("delete.json");

        internal ApiAction List => Path("list.json");
    }
}