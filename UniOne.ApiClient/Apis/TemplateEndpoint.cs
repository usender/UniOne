namespace Sender.UniOne.ApiClient.Apis
{
    internal class TemplateEndpoint : ApiEndpoint
    {
        internal TemplateEndpoint() 
            : base("template")
        { }

        internal ApiEndpoint Get => Path("get.json");

        internal ApiEndpoint Set => Path("set.json");

        internal ApiEndpoint Delete => Path("delete.json");

        internal ApiEndpoint List => Path("list.json");
    }
}
