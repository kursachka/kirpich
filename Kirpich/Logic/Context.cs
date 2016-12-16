using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Context:DbContext
     {
        public DbSet<MenuChapter> MenuChapters { get; set; }

        public DbSet<Menu> MainMenu { get; set; }

        public Context(): base("localsql")
        {

        }
    }  
    
}
