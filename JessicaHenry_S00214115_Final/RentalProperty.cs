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

        public string IcontRentalType
        {
            get
            {
                if (RentalType.GetType().Name == "House")
                {
                    return "/Images/flat.png";
                }

                else if (RentalType.GetType().Name == "Flat")
                {
                    return "/Images/flat.png";
                }

                else if (RentalType.GetType().Name == "Share")
                {
                    return "/Images/share.png";
                }
                else
                    return "Type not found";

            }
           
        }
        public string IcontRentalTypeImg { get; set; }


        //Constructor

        //Method 
        public decimal IncreaseRentPrice(int percentageAmount)
        {
            return Price + (Price * percentageAmount / 100);
        }

        //Get Icon
        public string GetPropertiesIcon(string rentalType)
        {

            if (rentalType == "House")
            {
                return  "/Images/flat.png";
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
        public override string ToString()
        {
            return $"{Location} {Price}"; 
        }


    }

    //Database 
    public class RentalData : DbContext
    {
        public RentalData() : base("MyFinalExamRentalPropertiesDb1055") { }
        public DbSet<RentalProperty> Properties { get; set; }

    }
}
