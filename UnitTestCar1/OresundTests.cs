using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class OresundTests
    {
        [TestMethod]
        [DataRow(true,161.0)]
        [DataRow(false,410.0)]
        public void PriceTestCar(bool brobizz, double result)
        {
           
            
            //arrange
            OresundCar testCar = new OresundCar();
            //act
            testCar.Brobizz = brobizz;
            double actualvalue = testCar.Price();
            //assert
            Assert.AreEqual(actualvalue, result);
            
        }

        [TestMethod]
        [DataRow(true, 73.0)]
        [DataRow(false, 210.0)]
        public void PriceTestMC(bool brobizz, double result)
        {


            //arrange
            OresundMC testMC = new OresundMC();
            //act
            testMC.Brobizz = brobizz;
            double actualvalue = testMC.Price();
            //assert
            Assert.AreEqual(actualvalue, result);

        }
    }
}
