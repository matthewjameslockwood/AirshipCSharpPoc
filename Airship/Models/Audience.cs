using Newtonsoft.Json;

namespace Airship.Models
{
    public class Audience
    {
        [JsonProperty("named_user")]
        public string NamedUser { get; set; }
    }
}