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
using System.Windows.Shapes;

namespace JessicaHenry_S00214115_Final
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            //Populate combobox
            cbxRentalType.ItemsSource = new string[] { "Flat", "House", "Share" };
        }

        private void AddRental_Click(object sender, RoutedEventArgs e)
        {
            //Add house to bd 
            RentalData db = new RentalData();
            string str = cbxRentalType.SelectedItem as string;
            RentalType rentalType = (RentalType)Enum.Parse(typeof(RentalType), str);


            using (db)
            {
                RentalProperty p1 = new RentalProperty()
                {
                    Location = tbkLocation.Text,
                    RentalType = rentalType,
                    Description = tbkDescription.Text,
                    Price = Convert.ToDecimal(tbkPrice.Text),
                    IcontRentalTypeImg = GetPropertiesIcon(rentalType.ToString())
                };

                db.Properties.Add(p1);
                db.SaveChanges();
            }
        }
        public string GetPropertiesIcon(string rentalType)
        {

            if (rentalType == "House")
            {
                return "/Images/flat.png";
            }

            else if (rentalType == "Flat")
            {
                return "/Images/flat.png";
            }

            else if (rentalType == "Share")
            {
                return "/Images/share.png";
            }
            else
                return "Type not found";
        }

    }
}
