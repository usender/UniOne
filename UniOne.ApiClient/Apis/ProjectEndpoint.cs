namespace Sender.UniOne.ApiClient.Apis
{
    internal class ProjectEndpoint : ApiEndpoint
    {
        internal ProjectEndpoint() 
            : base("project")
        {
        }

        internal ApiEndpoint Create => Path("create.json");

        internal ApiEndpoint Update => Path("update.json");

        internal ApiEndpoint Delete => Path("delete.json");

        internal ApiEndpoint List => Path("list.json");
    }
}
