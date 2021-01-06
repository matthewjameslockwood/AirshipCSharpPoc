using Newtonsoft.Json;

namespace Airship.Models
{
    public class Button
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("actions")]
        public Actions Actions { get; set; }
    }
}