using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JessicaHenry_S00214115_Final; 

namespace DatabaseManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create Database Object 
            RentalData db = new RentalData();

            using (db)
            {

                RentalProperty p1 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.Flat,
                    Description = "A modern 1 bedroom apartment located close to the campus." +
    "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
    "a small kitchen and a lounge/dining room",
                    Location = "Town Centre", 
                };

                RentalProperty p2 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.House,
                    Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There is also a dining room and a large sitting room",
                    Location = "Ballinode"
                };

                RentalProperty p3 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.Share,
                    Description = "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    Location = "Strandhill"
                };


                Console.WriteLine("Properties Created");
                //Add Properties to db
                db.Properties.Add(p1);
                db.Properties.Add(p2);
                db.Properties.Add(p3);

                Console.WriteLine("Properties Added to Db");

                db.SaveChanges();
                Console.WriteLine("Properties Saved to Database");
                //Save db

                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }

        }
    }
}
