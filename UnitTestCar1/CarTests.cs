using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            Car testCar = new Car();
            //act
            double actualvalue = testCar.Price();
            //assert
            Assert.AreEqual(actualvalue, 240.0);
        }

        public void PriceTestWithBrobizz()
        {
            //arrange
            Car testCar = new Car();
            testCar.Brobizz = true;
            //act

            double actualvalue = testCar.Price();
            //assert
            Assert.AreEqual(actualvalue, 228.0);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            Car testCar = new Car();
            //act
            string actualvalue = testCar.VehicleType();
            //assert
            Assert.AreEqual(actualvalue, "Car");
        }

        [TestMethod()]
        public void LicencePlateFailTest()
        {
            //arrange
            Car testCar = new Car();
            //act

            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testCar.LicencePlate = "AU428428");
        }

        [TestMethod()]
        public void LicencePlateTest()
        {
            //arrange
            Car testCar = new Car();
            //act
            testCar.LicencePlate = "AU42842";
            string actualvalue = testCar.LicencePlate;
            //assert
            Assert.AreEqual("AU42842", actualvalue);
        }
    }
}