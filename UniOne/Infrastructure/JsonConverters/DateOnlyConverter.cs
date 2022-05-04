using Newtonsoft.Json.Converters;

namespace Sender.UniOne.ApiClient.Infrastructure.JsonConverters
{
    internal class DateOnlyConverter : IsoDateTimeConverter
    {
        public DateOnlyConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
