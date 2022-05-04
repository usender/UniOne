namespace Sender.UniOne.ApiClient.Apis
{
    internal class SystemAction : ApiAction
    {
        internal SystemAction() 
            : base("system")
        {
        }

        internal ApiAction Info => Path("info.json");
    }
}