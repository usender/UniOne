using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Webhook.Models;

namespace Sender.UniOne.ApiClient.Webhook
{
    public class WebHookCallBackResponse
    {
        /// <summary>
        /// MD5-hash of the message body, in which the value “auth” is replaced by api key of the user/project; with this field the recipient of the notification can both authenticate and verify the notification integrity
        /// </summary>
        [JsonProperty("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// Array with only one element, containing events of a user/project
        /// </summary>
        [JsonProperty("events_by_user")]
        public UserEvent[] UserEvents { get; set; }
    }
}
