using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Infrastructure.Extensions
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerSettings DefaultSerializerSettings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static string ToJson(this object value)
        {
            return value.ToJson(DefaultSerializerSettings);
        }

        public static string ToJson(this object value, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, settings);
        }

        public static T FromJson<T>(this string value)
        {
            return JsonConvert.DeserializeObject<T>(value ?? string.Empty);
        }
    }
}
