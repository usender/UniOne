namespace Sender.UniOne.ApiClient.Apis
{
    internal class ProjectAction : ApiAction
    {
        internal ProjectAction() 
            : base("project")
        {
        }

        internal ApiAction Create => Path("create.json");

        internal ApiAction Update => Path("update.json");

        internal ApiAction Delete => Path("delete.json");

        internal ApiAction List => Path("list.json");
    }
}
