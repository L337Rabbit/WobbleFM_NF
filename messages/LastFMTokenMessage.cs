using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace com.okitoki.wobblefm.messages
{
    public class LastFMTokenMessage
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
