namespace Sender.UniOne.ApiClient.Apis
{
    internal class UnsubscribedEndpoint:ApiEndpoint
    {
        internal UnsubscribedEndpoint() 
            : base("unsubscribed")
        {
        }

        internal ApiEndpoint Set => Combine("set.json");

        internal ApiEndpoint Check => Combine("check.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}
