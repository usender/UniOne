using System;

namespace Sender.UniOne.ApiClient.Suppression
{
    public class SuppressionList
    {
        /// <summary>
        /// Cause of email being suppressed. One of: unsubscribed, temporary_unavailable, permanent_unavailable, complained 
        /// </summary>
        public SuppressionCause? Cause { get; set; }

        /// <summary>
        /// Source of email being suppressed. One of:
        ///  - user - suppressed by user with suppression/set;
        ///  - system - sending to the email is prohibited by system, for example due to multiple hard bounces;
        ///  - subscriber - the recipient reported spam or unsubscribed in the previous emails.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Date in the format YYYY-MM-DD hh:mm:ss to get suppression list from the “start_time” to the present day. Ignored if “cursor” is not empty.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The parameter indicates from which position the selection is to be started. Must be empty or omitted for the first data chunk. In order to get subsequent chunks, you must set the “cursor” parameter in your request, using the value received in response to the previous request.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Limits the number of records to be returned at one time, default is 50.
        /// </summary>
        public int? Limit { get; set; }
    }
}