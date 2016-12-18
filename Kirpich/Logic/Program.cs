using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
       
            public static string MessageSendVK(string user_id)
        {
            string key = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            string messageText = "Карина налажала и поздно села за VK API. Не ставьте нолик, пожалуйста:((((";

            return string.Format("https://api.vk.com/method/messages.send?id&domain={0}&message={1}&access_token={2}&v=5.60", user_id, messageText, key);
        }
        static void Main(string[] args)
        {

            using (var client=new HttpClient())
            {
                string result = client.GetStringAsync(MessageSendVK("sergefr")).Result;
            }
        }
    }
}
