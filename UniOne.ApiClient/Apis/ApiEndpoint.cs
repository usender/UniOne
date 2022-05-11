namespace Sender.UniOne.ApiClient.Apis
{
    /// <summary>
    /// API endpoints
    /// </summary>
    public class ApiEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        private const string PREFIX_ENDPOINT = "transactional/api/v1";

        /// <summary>
        /// Uri
        /// </summary>
        internal string Uri { get; private set; } = PREFIX_ENDPOINT;

        protected ApiEndpoint(string url)
        {
            Path(url);
        }

        /// <summary>
        /// Email endpoints
        /// </summary>
        internal static EmailEndpoint Email => new EmailEndpoint();

        /// <summary>
        /// Template  endpoints
        /// </summary>
        internal static TemplateEndpoint Template => new TemplateEndpoint();

        /// <summary>
        /// Webhook endpoints
        /// </summary>
        internal static WebhookEndpoint Webhook => new WebhookEndpoint();

        /// <summary>
        /// Unsubscribed endpoints
        /// </summary>
        internal static UnsubscribedEndpoint Unsubscribed => new UnsubscribedEndpoint();

        /// <summary>
        /// Suppression endpoints
        /// </summary>
        internal static SuppressionEndpoint Suppression => new SuppressionEndpoint();

        /// <summary>
        /// Domain endpoints
        /// </summary>
        internal static DomainEndpoint Domain => new DomainEndpoint();

        /// <summary>
        /// Project endpoints
        /// </summary>
        internal static ProjectEndpoint Project => new ProjectEndpoint();

        /// <summary>
        /// System endpoints
        /// </summary>
        internal static SystemEndpoint System => new SystemEndpoint();

        /// <summary>
        /// Merge path
        /// </summary>
        /// <param name="url">Postfix of url</param>
        /// <returns></returns>
        protected ApiEndpoint Path(string url)
        {
            Uri += "/" + url;
            return this;
        }
    }
}
