namespace Sender.UniOne.ApiClient.Apis
{
    /// <summary>
    /// API endpoints
    /// </summary>
    internal class ApiEndpoint
    {
        /// <summary>
        /// Url
        /// </summary>
        internal string Url { get; private set; } = "transactional/api/v1";

        private ApiEndpoint()
        {

        }

        protected ApiEndpoint(string url)
        {
            Url += $"/{url}";
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
        /// Event-dump endpoints
        /// </summary>
        internal static EventDumpEndpoint EventDump => new EventDumpEndpoint();

        /// <summary>
        /// Tag endpoints
        /// </summary>
        internal static TagEndpoint Tag => new TagEndpoint();

        /// <summary>
        /// Email-validation endpoints
        /// </summary>
        internal static EmailValidationEndpoints EmailValidation => new EmailValidationEndpoints();

        /// <summary>
        /// Merge path
        /// </summary>
        /// <param name="endOfUrl">Postfix of url</param>
        /// <returns></returns>
        protected ApiEndpoint Combine(string endOfUrl)
        {
            var apiEndpoint = new ApiEndpoint();
            apiEndpoint.Url = $"{Url}/{endOfUrl}";
            return apiEndpoint;
        }
    }
}