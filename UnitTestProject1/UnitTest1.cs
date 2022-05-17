using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JessicaHenry_S00214115_Final; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange 
            RentalProperty r1 = new RentalProperty()
                {
                    Price = 1000,
                    Location = "Sligo",
                };

                //Act
                decimal expectedResult = 1100;
                decimal resultOfNewPrice = r1.IncreaseRentPrice(10);

                //Assert 
                Assert.AreEqual(expectedResult, resultOfNewPrice);

        }
    }
}
