using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using com.okitoki.wobblefm.client;

namespace com.okitoki.wobblefm.messages
{
    public class LastFMSessionMessage
    {
        [JsonProperty("session")]
        public LastFMSession Session { get; set; }
    }
}
