using Logic.Show_Menu_All;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Queries
    {
        public IEnumerable<Show_Menu_Category> ReqForASpecifiedCategory(string category)
        {
            using (var c = new Context())
            {
                var result = (from s in c.MainMenu.Include("MenuChapter")
                              where s.MenuChapter.Category == category && s.Availability == "Da"
                              orderby s.Price descending

                              select new Show_Menu_Category
                              {
                                  Dish=s.NameOfDish,
                                  Price=s.Price
                              }
                              ).ToList();
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
                                Dish = s.NameOfDish,
                                Category = s.MenuChapter.Category,
                                Price = s.Price,
                                Availability = s.Availability
                            }
                            ).ToList();
                return menu;

            }
        }
        public IEnumerable<Show_Menu_Available> ReqForAvailable()
        {
            using (var c = new Context())
            {
                var result = (from s in c.MainMenu.Include("MenuChapter")
                              where s.Availability == "Da"
                              select new Show_Menu_Available
                              {
                                  Dish = s.NameOfDish,
                                  Price = s.Price,
                                  Category=s.MenuChapter.Category
                                  }).ToList();
                return result;
        }
        }

        public IEnumerable<Complex_Diner> ComplexDinner()
        {
            using (var c = new Context())
            {
                var menu = (from s in c.MainMenu.Include("MenuChapter")
                            where (s.NameOfDish == "Sup krest'janskij s risom") |
                                  (s.NameOfDish == "Sosiski otvarnye") |
                                  (s.NameOfDish == "Tomatnyj sok")
                            select new Complex_Diner
                            {
                                Dish = s.NameOfDish,
                                Category = s.MenuChapter.Category,
                                //Price = s.Price,
                                //YesNo = s.Availability
                            }
                            ).ToList();
                return menu;
            }
        }
    }

  


    }
  

