using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class Repository
    {
        private class ReadData
        {
            public List<Menu> MainMenu { get; set; }
            public List<MenuChapter> MenuChapters { get; set; }
        }
        ReadData readData;

        public IEnumerable<Menu> MainMenu
        {
            get { return readData.MainMenu; }
            private set { }
           
        }

        public IEnumerable<MenuChapter> MenuChapters
        {
            get { return readData.MenuChapters; }
            private set { }
        }


        public Repository()
        {
            var jstring = File.ReadAllText(("Menu.json"));
        //    var readDD = JsonConvert.DeserializeObject(jstring);
            readData = JsonConvert.DeserializeObject<ReadData>(jstring);
            MainMenu = readData.MainMenu;
            MenuChapters = readData.MenuChapters;
        }

           
        







    }





}
