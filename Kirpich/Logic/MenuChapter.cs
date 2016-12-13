using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class MenuChapter
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public List<Menu> list_of_dishes { get; set; }
    }
}
