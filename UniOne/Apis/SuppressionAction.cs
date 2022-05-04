namespace Sender.UniOne.ApiClient.Apis
{
    internal class SuppressionAction : ApiAction
    {
        internal SuppressionAction()
            : base("suppression")
        {
        }

        internal ApiAction Get => Path("get.json");

        internal ApiAction Delete => Path("delete.json");
    }
}
