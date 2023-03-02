namespace Sender.UniOne.ApiClient.Apis
{
    internal class TemplateEndpoint : ApiEndpoint
    {
        internal TemplateEndpoint() 
            : base("template")
        { }

        internal ApiEndpoint Get => Combine("get.json");

        internal ApiEndpoint Set => Combine("set.json");

        internal ApiEndpoint Delete => Combine("delete.json");

        internal ApiEndpoint List => Combine("list.json");
    }
}
