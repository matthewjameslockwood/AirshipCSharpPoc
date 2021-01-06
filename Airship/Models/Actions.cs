using Newtonsoft.Json;

namespace Airship.Models
{
    public class Actions
    {
        [JsonProperty("open")]
        public OpenUrlAction Open { get; set; }
    }
}