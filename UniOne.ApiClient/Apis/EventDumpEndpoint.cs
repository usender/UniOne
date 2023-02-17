namespace Sender.UniOne.ApiClient.Apis
{
    internal class EventDumpEndpoint : ApiEndpoint
    {
        internal EventDumpEndpoint()
            : base("event-dump")
        {

        }

        internal ApiEndpoint Create => Combine("create.json");

        internal ApiEndpoint Get => Combine("get.json");

        internal ApiEndpoint List => Combine("list.json");

        internal ApiEndpoint Delete => Combine("delete.json");
    }
}
