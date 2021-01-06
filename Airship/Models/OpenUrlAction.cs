using Newtonsoft.Json;

namespace Airship.Models
{
    public class OpenUrlAction
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}