using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace UnitTestsTicketSystemClassLibrary
{
    [TestClass]
    public class WeekendDiscountTests
    {
        [TestMethod]
        [DataRow(true, 182.4)]
        [DataRow(false, 192.0)]
        public void StoreBaeltDiscountTest(bool brobizz, double result)
        {
            //arrange
            WeekendDiscount discountTest = new WeekendDiscount();
            Car testCar = new Car();
            //act
            testCar.Date = new DateTime(2022, 10, 15);
            testCar.Brobizz = brobizz;
            double actualvalue = discountTest.StoreBaeltDiscount(testCar);
            //assert
            Assert.AreEqual(actualvalue, result);
        }
    }
}
