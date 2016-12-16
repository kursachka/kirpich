using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Queries
    {
        public IEnumerable<Menu> ReqForASpecifiedCategory(string category)
        {
            using (var c = new Context())
            {
                var result = (from s in c.MainMenu.Include("MenuChapter")
                              where s.MenuChapter.Category == category && s.Availability == "Da"

                              select s).ToList();
                return result;

            }
        }
        public  IEnumerable<Show_Menu> ShowMenu()
        {
            using (var c=new Context())
            {
                var menu = (from s in c.MainMenu.Include("MenuChapter")
                            select new Show_Menu
                            {
                                Name=s.NameOfDish,
                                Type=s.MenuChapter.Category,
                                Price=s.Price,
                                YesNo=s.Availability
                            }
                            ).ToList();
                return menu;

            }
        }

    }
    public class Show_Menu
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string YesNo { get; set; }

    }
}
