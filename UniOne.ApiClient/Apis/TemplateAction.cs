namespace Sender.UniOne.ApiClient.Apis
{
    internal class TemplateAction : ApiAction
    {
        internal TemplateAction() 
            : base("template")
        { }

        internal ApiAction Get => Path("get.json");

        internal ApiAction Set => Path("set.json");

        internal ApiAction Delete => Path("delete.json");

        internal ApiAction List => Path("list.json");
    }
}
