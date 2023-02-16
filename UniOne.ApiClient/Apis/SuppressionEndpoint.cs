namespace Sender.UniOne.ApiClient.Apis
{
    internal class SuppressionEndpoint : ApiEndpoint
    {
        internal SuppressionEndpoint()
            : base("suppression")
        {
        }

        internal ApiEndpoint Get => Path("get.json");

        internal ApiEndpoint Delete => Path("delete.json");

        internal ApiEndpoint Set => Path("set.json");

        internal ApiEndpoint List => Path("list.json");
    }
}
