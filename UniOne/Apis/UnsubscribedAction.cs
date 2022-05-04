namespace Sender.UniOne.ApiClient.Apis
{
    internal class UnsubscribedAction:ApiAction
    {
        internal UnsubscribedAction() 
            : base("unsubscribed")
        {
        }

        internal ApiAction Set => Path("set.json");

        internal ApiAction Check => Path("check.json");

        internal ApiAction List => Path("list.json");
    }
}
