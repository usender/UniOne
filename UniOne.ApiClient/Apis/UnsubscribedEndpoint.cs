namespace Sender.UniOne.ApiClient.Apis
{
    internal class UnsubscribedEndpoint:ApiEndpoint
    {
        internal UnsubscribedEndpoint() 
            : base("unsubscribed")
        {
        }

        internal ApiEndpoint Set => Path("set.json");

        internal ApiEndpoint Check => Path("check.json");

        internal ApiEndpoint List => Path("list.json");
    }
}
