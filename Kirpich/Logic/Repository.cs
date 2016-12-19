using Newtonsoft.Json;
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

        //public static string GetNewMessage()
        //{
        //    string key = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
        //    return string.Format("https://api.vk.com/method/messages.get?&out=0&access_token={2}&v=5.60", key);
        //}

        //public static string MessageSendVK(string user_id)
        //{
        //    string key = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
        //    string messageText = "Карина налажала и поздно села за VK API. Не ставьте нолик, пожалуйста:((((";

        //    return string.Format("https://api.vk.com/method/messages.send?id&domain={0}&message={1}&access_token={2}&v=5.60", user_id, messageText, key);


        //}
        //public static string GetContent()
        //{

        //    using (var client = new HttpClient())
        //    {
        //        var result = client.GetStringAsync(()).Result;
        //        return JsonConvert.DeserializeObject<ResponseVkMessage>(result);
        //    }
        //}

        public static string MessageSendVK(string user_id)
        {
            var data = GetInfoAboutUser();
            
            {

            }
            string key = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            string messageText = "Карина налажала и поздно села за VK API. Не ставьте нолик, пожалуйста:((((";

            return String.Format("https://api.vk.com/method/messages.send?id&domain={0}&message={1}&access_token={2}&v=5.60", user_id, messageText, key);
        }
        public static string GetMessage()
        {
            string key= "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            return String.Format("https://api.vk.com/method/messages.get?out=0&count=5&access_token={0}&v=5.60", key);
        }
        public static  ResponseVkMessage GetInfoAboutUser()
        {
            using (var client = new HttpClient())
            {
                string result = client.GetStringAsync(GetMessage()).Result;
                var data= JsonConvert.DeserializeObject<ResponseVkMessage>(result);
                return data.Items.Select(item=> new UserInfo
                {
                    Id=item.Id,
                    
                })


                using (var client = new HttpClient())
                {
                    string result = await client.GetStringAsync($"https://www.googleapis.com/customsearch/v1?q={query}&cx={_engineId}&key={_appKey}");
                    var data = JsonConvert.DeserializeObject<Result>(result);

                    // Convertion from DTO to Domain Model
                    return data.Items.Select(item => new SearchResult
                    {
                        Title = item.Title,
                        Description = item.Snippet,
                        Url = item.Link
                    }).ToList();
                }
        }
    }
}