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

namespace JessicaHenry_S00214115_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> allProperties = new List<RentalProperty>();
        RentalData db = new RentalData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Properties
                        select p;
            allProperties = query.ToList();
            lbxProperties.ItemsSource = allProperties;
        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty selected = lbxProperties.SelectedItem as RentalProperty;

            if (selected != null)
            {
                tbxPropertiesDetails.Text = selected.Description;
            }
        }

        private void Click_Addbtn(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show(); //second window is modal 
            this.Close();
        }
    }
}
