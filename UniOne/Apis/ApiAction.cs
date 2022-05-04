namespace Sender.UniOne.ApiClient.Apis
{
    public class ApiAction
    {
        private const string ROOT_URL = "/en/transactional/api/v1";

        internal string Uri { get; private set; } = ROOT_URL;

        internal ApiAction(string url) => Path(url);

        internal static EmailAction Email => new EmailAction();

        internal static TemplateAction Template => new TemplateAction();
        
        internal static WebhookAction Webhook => new WebhookAction();

        internal static UnsubscribedAction Unsubscribed => new UnsubscribedAction();

        internal static SuppressionAction Suppression => new SuppressionAction();

        internal static DomainAction Domain => new DomainAction();

        internal static ProjectAction Project => new ProjectAction();

        internal static SystemAction System => new SystemAction();
        
        protected ApiAction Path(string url)
        {
            Uri += "/" + url;
            return this;
        }
    }
}