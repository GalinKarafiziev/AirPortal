using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procp;

namespace UnitTestProject
{
    [TestClass]
    public class AirportTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Airport airport = new Airport();
            Assert.IsNotNull(airport.getDrop("drop1"));
            Assert.IsNotNull(airport.getDrop("drop2"));
            Assert.IsNotNull(airport.getDrop("drop3"));
            Assert.IsNotNull(airport.getDrop("drop4"));
        }
        [TestMethod]
        public void GetBaggateTest()
        {
            Airport airport = new Airport();
           

            Assert.IsNotNull(airport.GetBaggageByNumber(1));
        }

        [TestMethod]
        public void GetNumberOfCheckInsTest()
        {
            Airport airport = new Airport();
            CheckIn c = new CheckIn(airport.getDrop("drop1"), "check");
            airport.addCheckin(c);
            Assert.AreEqual(1, airport.GetNumberOfChickIns("drop1"));
        }
    }
}
