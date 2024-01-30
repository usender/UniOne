namespace Sender.UniOne.ApiClient.Apis
{
    internal class SuppressionEndpoint : ApiEndpoint
    {
        internal SuppressionEndpoint()
            : base("suppression")
        {
        }

        internal ApiEndpoint Get => Combine("get.json");

        internal ApiEndpoint Delete => Combine("delete.json");

        internal ApiEndpoint Set => Combine("set.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}
