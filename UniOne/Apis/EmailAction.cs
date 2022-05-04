namespace Sender.UniOne.ApiClient.Apis
{
    internal class EmailAction : ApiAction
    {
        internal EmailAction()
            : base("email")
        {
        }

        internal ApiAction Send => Path("send.json");

        internal ApiAction Subscribe => Path("subscribe.json");
    }
}
