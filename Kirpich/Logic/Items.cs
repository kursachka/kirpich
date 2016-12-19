using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Items
    {
        [JsonProperty("response")]
        public ResponseVkMessage Response { get; set; }
    }
}
