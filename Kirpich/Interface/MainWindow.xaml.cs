using Logic;
using Logic.Show_Menu_All;
using System;
using System.Net.Http;
using System.Windows;
using System.Windows.Threading;

namespace Interface
{

    public partial class MainWindow : Window
    {

        
        Queries queries = new Queries();
       
        public MainWindow()
        {
            InitializeComponent();
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


            tbCena.Text = "120";
        }

        private void CurrentCellChanged(object sender, EventArgs e)
        {
            var resMenu = dataGrid.ItemsSource;
            int sum = 0;
            try
            {
                foreach (Show_Menu_Available item in resMenu)
                {

                    if (item.Check == true)
                    { sum = sum + item.Price; }
                    tbCena.Text = sum.ToString();
                }
                
            }
            catch
            {
                try
                {
                    foreach (Show_Menu_Category item in resMenu)
                    {
                        if (item.Check == true)
                        { sum = sum + item.Price; }
                        tbCena.Text = sum.ToString();
                    }
                    
                }
                catch
                {
                    foreach (Show_Menu item in resMenu)
                    {
                        if (item.Check == true)
                        { sum = sum + item.Price; }
                        tbCena.Text = sum.ToString();
                    }
                    
                }
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //using (var client = new HttpClient())
            //{
            //    string result = client.GetStringAsync(Repository.MessageSendVK("rimskiy_nikita")).Result;
            //}

        }

        private void ButtonVk_Click(object sender, RoutedEventArgs e)
        {
            Repository.GetInfoAboutUser();

        }
    }
}    
    



