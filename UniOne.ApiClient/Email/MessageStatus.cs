using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Email
{
    /// <summary>
    /// <see cref="http://eu1.unione.io/ru/docs/page/webhook_set_v1#status"/>
    /// </summary>
    [Flags]
    public enum MessageStatus
    {
        /// <summary>
        /// The message is sent, but not delivered yet
        /// </summary>
        [Description("sent")]
        [EnumMember(Value = "sent")]
        Sent = 1,

        /// <summary>
        /// The message is delivered. Can be changed to “opened” and “clicked”
        /// </summary>
        [Description("delivered")]
        [EnumMember(Value = "delivered")]
        Delivered = 2,

        /// <summary>
        /// The message is delivered and read. Can be changed to “clicked”
        /// </summary>
        [Description("opened")]
        [EnumMember(Value = "opened")]
        Opened = 4,

        /// <summary>
        /// The message is delivered, read and a the transition has been registered for one of the links in the letter
        /// </summary>
        [Description("clicked")]
        [EnumMember(Value = "clicked")]
        Clicked = 8,

        /// <summary>
        /// The message is delivered to the recipient and read by him, but he clicked the unsubscribe link in the email. The status is final
        /// </summary>
        [Description("unsubscribed")]
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed = 16,

        /// <summary>
        /// Failed to deliver the message due to
        /// <list type="bullet">
        /// <item><term>no attempts of sending or the sending is delayed</term></item>
        /// <item><term>destination mailbox is full</term></item>
        /// <item><term>the email was rejected by the recipient’s domain as spam</term></item>
        /// <item><term>there was at least one attempt to send, the system keeps trying to send the email</term></item>
        /// <item><term>the recipient’s domain does not accept email due to the incorrect settings</term></item>
        /// <item><term>the sending was canceled</term></item>
        /// <item><term>the sending was canceled due to incorrect sender data</term></item>
        /// <item><term>insufficient funds</term></item>
        /// <item><term>the email is temporary unavailable</term></item>
        /// </list>
        /// </summary>
        [Description("soft_bounced")]
        [EnumMember(Value = "soft_bounced")]
        SoftBounced = 32,

        /// <summary>
        /// Failed to deliver the message due to
        /// <list type="bullet">
        /// <item><term>recipient’s email address does not exist or had been deleted</term></item>
        /// <item><term>email address is not used</term></item>
        /// <item><term>the recipient’s domain does not accept any emails at all for any reason</term></item>
        /// <item><term>incorrect email</term></item>
        /// <item><term>the recipient has unsubscribed</term></item>
        /// <item><term>email address is unavailable</term></item>
        /// <item><term>the letter exceeds the allowable size</term></item>
        /// <item><term>the resend terms have been expired</term></item>
        /// </list>
        /// </summary>
        [Description("hard_bounced")]
        [EnumMember(Value = "hard_bounced")]
        HardBounced = 64,

        /// <summary>
        /// The message is delivered, but it was reported as spam by the recipient. UniOne can receive and process the spam complaint from the following domains
        /// <see cref="http://en.wikipedia.org/wiki/Feedback_loop_(email)"/>
        /// <list type="bullet">
        /// <item><term>mail.ru</term></item>
        /// <item><term>msn.com, outlook.com, hotmail.com, live.com</term></item>
        /// <item><term>ukr.net</term></item>
        /// <item><term>yahoo.com</term></item>
        /// <item><term>aol.com</term></item>
        /// </list>
        /// </summary>
        [Description("spam")]
        [EnumMember(Value = "spam")]
        Spam = 128
    }
}