namespace Sender.UniOne.ApiClient.Apis
{
    internal class TagEndpoint : ApiEndpoint
    {
        internal TagEndpoint()
            : base("tag")
        {
        }

        internal ApiEndpoint List => Combine("list.json");

        internal ApiEndpoint Delete => Combine("delete.json");
    }
}
