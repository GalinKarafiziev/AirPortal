using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procp;

namespace UnitTestProject
{
    [TestClass]
    public class CheckInTest
    {
        [TestMethod]
        public void InitialiseCheckIn()
        {
            DropOff drop = new DropOff(5, "TestCheckIn");
            CheckIn checkIn = new CheckIn(drop, "CheckIn");

            Assert.IsNotNull(checkIn);
        }

        [TestMethod]
        public void PassBaggageTest()
        {
            DropOff drop = new DropOff(5, "TestCheckIn");
            CheckIn checkIn = new CheckIn(drop, "CheckIn");
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);

            checkIn.PassBaggage(baggage);
            Assert.AreEqual(checkIn.baggage.Count, 1);
        }

        [TestMethod]
        public void PassBaggageTestNext()
        {
            DropOff drop = new DropOff(5, "TestCheckIn");
            CheckIn checkIn = new CheckIn(drop, "CheckIn");
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);
            Conveyor conveyor = new Conveyor(drop, "Conv1");
            checkIn.next = conveyor;
            checkIn.PassBaggage(baggage);
            Assert.AreEqual(checkIn.baggage.Count, 1);
            Assert.AreEqual(conveyor.baggage.Count, 1);
        }
    }
}
