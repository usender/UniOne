using System.ComponentModel;
using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.EventDump
{
    public enum EventDumpStatusEnum
    {
        /// <summary>
        /// The task is in the queue, processing is not started yet
        /// </summary>
        [Description("queued")]
        [EnumMember(Value = "queued")] 
        Queued,

        /// <summary>
        /// The request is being processed
        /// </summary>
        [Description("in_process")]
        [EnumMember(Value = "in_process")] 
        InProcess,

        /// <summary>
        /// The task is finished, dump file is ready for download
        /// </summary>
        [Description("ready")]
        [EnumMember(Value = "ready")] 
        Ready,

        /// <summary>
        /// Processing failed due to an internal error
        /// </summary>
        [Description("failed")]
        [EnumMember(Value = "failed")] 
        Failed
    }
}
