using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ResponseVkMessage
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UserInfo Items { get; set; }
    }
}
