using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace com.okitoki.wobblefm.client
{
    public class LastFMSession
    {
        [JsonProperty("name")]
        public string User { get; set; }
        
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("subscriber")]
        public int Subscriber { get; set; }
    }
}
