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
using Logic.Show_Menu_All;

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

       

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
                
                    var resMenu = queries.ShowMenu();
                    dataGrid.ItemsSource = resMenu;
                    dataGrid.Columns[0].IsReadOnly = true;
                    dataGrid.Columns[1].IsReadOnly = true;
                    dataGrid.Columns[2].IsReadOnly = true;
                    dataGrid.Columns[3].IsReadOnly = true;
                    tbCena.Text = "";
        }



        private void buttonComlex_Click(object sender, RoutedEventArgs e)
        { 

            var resComplex = queries.ComplexDinner();
            dataGrid.ItemsSource = resComplex;

            dataGrid.Columns[0].IsReadOnly = true;
            dataGrid.Columns[1].IsReadOnly = true;
            //dataGrid.Columns[2].IsReadOnly = true;
            //dataGrid.Columns[3].IsReadOnly = true;

            tbCena.Text = "120";
        }

        private void CurrentCellChanged(object sender, EventArgs e)
        {
            var resMenu = dataGrid.ItemsSource;

            int sum = 0;


            foreach (Show_Menu_Available item in resMenu)
            {
                if (item.Check == true)
                { sum = sum + item.Price; }
                tbCena.Text = sum.ToString();
            }


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


