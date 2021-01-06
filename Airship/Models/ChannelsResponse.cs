namespace Airship.Models
{
    namespace QuickType
    {
        using System;
        using Newtonsoft.Json;

        public partial class ChannelsResponse
        {
            [JsonProperty("next_page")]
            public Uri NextPage { get; set; }

            [JsonProperty("channels")]
            public Channel[] Channels { get; set; }
        }
    }
}
