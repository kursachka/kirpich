using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Menu
    {
        #region Columns
        public int Id { get; set; }
        public string NameOfDish { get; set; }
        public MenuChapter MenuChapter { get; set; }
        public string Price { get; set; }
        public string Availability { get; set; }
        #endregion
    }
}
