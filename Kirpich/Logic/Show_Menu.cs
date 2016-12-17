using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Show_Menu
    {
        public string Dish { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Availability { get; set; }

    }
   public  class Show_Menu_Category
    {
        public string Dish { get; set; }
        public int Price { get; set; }
        
    }
    public class Show_Menu_Available
    {
        public string Dish { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
