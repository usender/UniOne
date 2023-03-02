namespace Sender.UniOne.ApiClient.Apis
{
    internal class ProjectEndpoint : ApiEndpoint
    {
        internal ProjectEndpoint() 
            : base("project")
        {
        }

        internal ApiEndpoint Create => Combine("create.json");

        internal ApiEndpoint Update => Combine("update.json");

        internal ApiEndpoint Delete => Combine("delete.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}
