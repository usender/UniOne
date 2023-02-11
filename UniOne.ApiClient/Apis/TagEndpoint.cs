namespace Sender.UniOne.ApiClient.Apis
{
    internal class TagEndpoint : ApiEndpoint
    {
        internal TagEndpoint()
            : base("tag")
        {
        }

        internal ApiEndpoint List => Path("list.json");

        internal ApiEndpoint Delete => Path("delete.json");
    }
}
