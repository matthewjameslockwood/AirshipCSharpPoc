using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airship.Models
{
    public class PushObject
    {
        [JsonProperty("notification")]
        public Notification Notification { get; set; }

        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        // web, android, ios
        [JsonProperty("device_types")]
        public List<string> DeviceTypes { get; set; }

    }
}
