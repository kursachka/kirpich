using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class MenuChapter
    {
        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("menuChapter")]
        public string Category { get; set; }

    }
}
