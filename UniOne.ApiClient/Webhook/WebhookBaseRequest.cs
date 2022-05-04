namespace Sender.UniOne.ApiClient.Webhook
{
    internal abstract class WebhookBaseRequest : BaseRequest
    {
        protected WebhookBaseRequest(string url)
        {
            Url = url;
        }

        /// <summary>
        /// URL that will receive the notification when an event occurs
        /// </summary>
        public string Url { get; set; }
    }
}
