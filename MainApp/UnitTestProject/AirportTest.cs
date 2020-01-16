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
            CheckIn c = new CheckIn(airport.getDrop("drop1"), "check", 1);
            airport.addCheckin(c);
            Assert.AreEqual(1, airport.GetNumberOfChickIns("drop1"));
        }

        [TestMethod]
        public void buyTicketTest()
        {
            Airport airport = new Airport();
            Passenger passenger = new Passenger("Err", airport.getDrop("drop1"));
            airport.addPassenger(passenger);
            airport.buyTicket(passenger, 2.25, "Err");

            Assert.AreEqual(airport.getAllPassengers().Count, 101);
            Assert.AreEqual(airport.GetNumberOfTicketsSold(airport.getDrop("drop1")), 1);
        }

        [TestMethod]
        public void getBagByDropOffTest()
        {
            Airport airport = new Airport();
            airport.getBagByDropOff(airport.getDrop("drop1"));

            Assert.IsTrue(airport.getBagByDropOff(airport.getDrop("drop1")).Count > 0);
        }

        [TestMethod]
        public void getPassengersTest()
        {
            Airport airport = new Airport();
            airport.getPassengers(airport.getDrop("drop1"));

            Assert.IsNotNull(airport.getPassengers(airport.getDrop("drop1")));
            Assert.IsTrue(airport.getPassengers(airport.getDrop("drop1")).Count > 0);
        }

        [TestMethod]
        public void GetCheckInByIdTest()
        {
            Airport aiport = new Airport();
            aiport.addCheckin(new CheckIn(aiport.getDrop("drop1"), "check1", 1));
            aiport.addCheckin(new CheckIn(aiport.getDrop("drop2"), "check2", 1));
            //CheckIn checkIn = new CheckIn(new DropOff(1, "drop1"), "check1", 1);
            Assert.IsNotNull(aiport.GetCheckInById(1));

        }
    }
}
