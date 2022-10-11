using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace UnitTests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            MC testMC = new MC();
            //act
            double actualvalue = testMC.Price();
            //assert
            Assert.AreEqual(actualvalue, 125.0);
        }

        [TestMethod()]
        public void PriceTestWithBrobizz()
        {
            //arrange
            MC testMC = new MC();
            testMC.Brobizz = true;
            //act
            double actualvalue = testMC.Price();
            //assert
            Assert.AreEqual(actualvalue, 118,75);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            MC testMC = new MC();
            //act
            string actualvalue = testMC.VehicleType();
            //assert
            Assert.AreEqual(actualvalue, "MC");
        }

        [TestMethod()]
        public void LicencePlateFailTest()
        {
            //arrange
            MC testMC = new MC();
            //act

            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testMC.LicencePlate = "AU428428");
        }

        [TestMethod()]
        public void LicencePlateTest()
        {
            //arrange
            MC testMC = new MC();
            //act
            testMC.LicencePlate = "AU42842";
            string actualvalue = testMC.LicencePlate;
            //assert
            Assert.AreEqual("AU42842", actualvalue);
        }

    }
}

