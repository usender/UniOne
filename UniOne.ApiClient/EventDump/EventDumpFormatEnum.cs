using System.ComponentModel;
using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.EventDump
{
    public enum EventDumpFormatEnum
    {
        /// <summary>
        /// File format, either “csv”
        /// </summary>
        [Description("csv")]
        [EnumMember(Value = "csv")]
        Csv,

        /// <summary>
        /// File format, either “csv_gzip”
        /// </summary>
        [Description("csv_gzip")]
        [EnumMember(Value = "csv_gzip")]
        CsvGzip
    }
}
