namespace Sender.UniOne.ApiClient
{
    public class UniOneSettings
    {
        /// <summary>
        /// API endpoint (or base URL) depends on which datacenter the user is registered at.
        /// <list type="bullet">
        ///     <item>
        ///         <term>UniOne USA and Canada Instance</term>
        ///         <description>https://us1.unione.io</description>
        ///     </item>
        ///     <item>
        ///         <term>UniOne European Instance</term>
        ///         <description>https://eu1.unione.io</description>
        ///     </item>
        /// </list>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Authorization key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// API language. Default is english
        /// </summary>
        public Language DefaultLanguage { get; set; } = Language.English;

        /// <summary>
        /// The property indicates whether the submitted validation request should be checked
        /// Validation is checked according to official documentation
        /// <remarks>Currently, the project is not fully verified and validation may not occur correctly</remarks>
        /// </summary>
        public bool IsNeedValidatingRequestBeforeSending { get; set; }
    }
}