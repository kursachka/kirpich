using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        { Queries que = new Queries();
            foreach (var item in que.ReqForASpecifiedCategory("Desert"))
            {
                Console.WriteLine(item.NameOfDish + " " + item.Price);
            }
            
            Console.ReadKey();
        }
    }
}
