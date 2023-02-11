namespace Sender.UniOne.ApiClient.Apis
{
    internal class EventDumpEndpoint : ApiEndpoint
    {
        internal EventDumpEndpoint()
            : base("event-dump")
        {

        }

        internal ApiEndpoint Create => Path("create.json");

        internal ApiEndpoint Get => Path("get.json");

        internal ApiEndpoint List => Path("list.json");

        internal ApiEndpoint Delete => Path("delete.json");
    }
}
