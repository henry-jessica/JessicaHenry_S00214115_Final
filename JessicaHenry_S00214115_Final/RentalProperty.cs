using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessicaHenry_S00214115_Final
{
    public enum RentalType
    {
        House, 
        Flat,
        Share
    }
    public class RentalProperty
    {
        //Propreties 
        public int ID { get; set; }
        public string Location { get; set; }
        public RentalType RentalType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Constructor

        //Method 
        public decimal IncreaseRentPrice(int percentageAmount)
        {
            return Price + (Price * percentageAmount / 100);
        }

    }

    //Database 
    public class RentalData : DbContext
    {
        public RentalData() : base("MyFinalExamRentalPropertiesDb") { }
        public DbSet<RentalProperty> Properties { get; set; }

    }
}
