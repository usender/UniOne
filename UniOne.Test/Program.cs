using Newtonsoft.Json;
using Sender.UniOne.ApiClient;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sender.UniOne.Test
{
    class Program
    {
        private static Client _client;

        static async Task Main(string[] args)
        {
            var settings = new UniOneSettings
            {
                ApiKey = "Your API key here",
                Endpoint = "chose by region", // https://eu1.unione.io or https://us1.unione.io
                DefaultLanguage = Language.English,
                IsNeedValidatingRequestBeforeSending = false
            };

            _client = new Client(settings);

            //system info
            var response = await _client.SystemInfo();
            ResponseToConsole(response);

            ////send email
            //ResponseToConsole(await _client.EmailSendAsync("noreply@email.com", new[] { "your@email.com" }));

            Console.ReadKey();
        }

        private static void ResponseToConsole<T>(T response) where T : BaseResponse
        {
            Console.WriteLine($"{GetDashString(3)} {typeof(T).Name} {GetDashString(10)}");

            var json = JsonConvert.SerializeObject(response, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });

            Console.WriteLine(json);
            Console.WriteLine(GetDashString(30));
            Console.WriteLine();
        }

        private static string GetDashString(int dashCount)
        {
            return string.Join(string.Empty, Enumerable.Repeat('-', dashCount));
        }
    }
}
