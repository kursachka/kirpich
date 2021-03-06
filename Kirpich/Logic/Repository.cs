﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

        public static string MessageSendVK(int user_id)
        {
            string key = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            string messageText = "Карина налажала и поздно села за VK API. Не ставьте нолик, пожалуйста:((((";

            return String.Format("https://api.vk.com/method/messages.send?user_id={0}&message={1}&access_token={2}&v=5.60", user_id, messageText, key);
        }

        public static string GetMessages()
        {
            string key= "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            return String.Format("https://api.vk.com/method/messages.get?out=0&count=3&access_token={0}&v=5.60", key);
        }
        public static ResponseVkMessage GetInfoAboutUser()
        {
            using (var client = new HttpClient())
            {
               var result = client.GetStringAsync(GetMessages()).Result;
               var data= JsonConvert.DeserializeObject<Items>(result);
            
                List<UserInfo> list = new List<UserInfo>();
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new UserInfo()
                    { User_id = data.Response.Items[i].User_id, Body = data.Response.Items[i].Body });
                }

                return new ResponseVkMessage()
                { Items = list };

            }
        }
    }
}