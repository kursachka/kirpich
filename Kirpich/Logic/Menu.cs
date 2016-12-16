using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Menu
    {
        public int Id { get; set; }

        [JsonProperty("nameofDish")]
        public string NameOfDish { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("menuChapterId")]
        public int MenuChapterId { get; set; }

        public MenuChapter MenuChapter { get; set; }
    }
}
