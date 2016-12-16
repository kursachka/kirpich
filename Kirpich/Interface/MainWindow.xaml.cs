using Logic;
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
using System.Data.OleDb;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queries queries = new Queries();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
           
                    var resMenu = queries.ShowMenu();
                    dataGrid.ItemsSource = resMenu;
           }

        private void buttonAvailable_Click(object sender, RoutedEventArgs e)
        {
            var resAvailable = queries.ReqForAvailable();
            dataGrid.ItemsSource = resAvailable;
        }

        private void buttonFirstCourse_Click(object sender, RoutedEventArgs e)
        {
            var resFirstCourse = queries.ReqForASpecifiedCategory("Pervoe bljudo");
            dataGrid.ItemsSource = resFirstCourse;
        }

        private void buttonSecondCourse_Click(object sender, RoutedEventArgs e)
        {
            var resSecondCourse = queries.ReqForASpecifiedCategory("Vtoroe bljudo");
            dataGrid.ItemsSource = resSecondCourse;
        }

        private void buttonDrinks_Click(object sender, RoutedEventArgs e)
        {
            var resDrinks = queries.ReqForASpecifiedCategory("Napitok");
            dataGrid.ItemsSource = resDrinks;
        }

        private void buttonDeserts_Click(object sender, RoutedEventArgs e)
        {
            var resDeserts = queries.ReqForASpecifiedCategory("Desert");
            dataGrid.ItemsSource = resDeserts;
        }
    }
    }


