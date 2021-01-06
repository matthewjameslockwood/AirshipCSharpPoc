namespace Airship.Models
{
    namespace QuickType
    {
        using Newtonsoft.Json;

        public partial class Ios
        {
            [JsonProperty("badge")]
            public long Badge { get; set; }

            [JsonProperty("quiettime")]
            public QuietTime QuietTime { get; set; }

            [JsonProperty("tz")]
            public string Tz { get; set; }
        }
    }
}
