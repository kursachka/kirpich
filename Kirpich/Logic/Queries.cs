using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Queries
    {
        public IEnumerable<Menu> ReqForASpecifiedCategory(string category)
        {
            using (var c = new Context())
            {
                var result = (from s in c.MainMenu.Include("MenuChapter")
                              where s.MenuChapter.Category== category && s.Availability=="Da"

                              select s).ToList();
                return result;

            }
        }      }
}
