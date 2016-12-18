using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VKAPI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            auth();

        }
        public void auth()
        {
            string appid = "4b72a0dec3ca9684a2725e73ce50ea5a76c7936879857397b86d73b0b728a943df38cbe0897b10aedfeae";
            string scope = "messages";
            string url = "https://oauth.vk.com/authorize?client_id=" + appid + "&groups_ids=135579504,123456&display=popup&redirect_uri=http://api.vkontakte.ru/blank,htmlcallback&scope=" + scope + "&response_type=token";
        }
        
    }
}
