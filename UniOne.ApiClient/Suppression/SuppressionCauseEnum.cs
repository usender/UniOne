using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Suppression
{
    public enum SuppressionCause
    {
        /// <summary>
        /// Email is unsubscribed
        /// </summary>
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,

        /// <summary>
        /// The email address is unavailable. This means that over the next three days sending to this address will return an error. Email may be temporarily unavailable due to several reasons, e.g
        ///  1. a previous email has been rejected by the recipient’s server for spam;
        ///  2. the recipient’s mailbox is full or is not used
        ///  3. recipient’s domain does not accept mail
        ///  4. sending server was rejected due to blacklisting
        /// </summary>
        [EnumMember(Value = "temporary_unavailable")]
        TemporaryUnavailable,

        /// <summary>
        /// The email address is permanently unavailable due to multiple hard bounces
        /// </summary>
        [EnumMember(Value = "permanent_unavailable")]
        PermanentUnavailable,

        /// <summary>
        /// The recipient reported spam in the previous emails
        /// </summary>
        [EnumMember(Value = "complained")]
        Complained
    }
}