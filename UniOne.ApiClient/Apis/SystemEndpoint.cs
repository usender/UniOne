namespace Sender.UniOne.ApiClient.Apis
{
    internal class SystemEndpoint : ApiEndpoint
    {
        internal SystemEndpoint() 
            : base("system")
        {
        }

        /// <summary>
        /// API end part of endpoint
        /// </summary>
        internal ApiEndpoint Info => Combine("info.json");
    }
}