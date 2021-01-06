namespace Airship.Models
{
    namespace QuickType
    {
        using Newtonsoft.Json;

        public partial class QuietTime
        {
            [JsonProperty("start")]
            public string Start { get; set; }

            [JsonProperty("end")]
            public string End { get; set; }
        }
    }
}
