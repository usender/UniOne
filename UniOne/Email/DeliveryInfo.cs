using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Email
{
    public class DeliveryInfo
    {
        [JsonProperty("delivery_status")]
        public string Status { get; set; }

        [JsonProperty("destination_response")]
        public string DestinationResponse { get; set; }
        
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }
    }
}
