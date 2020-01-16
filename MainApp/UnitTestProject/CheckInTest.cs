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
            CheckIn checkIn = new CheckIn(drop, "CheckIn", 1);

            Assert.IsNotNull(checkIn);
        }

        [TestMethod]
        public void PassBaggageTest()
        {
            DropOff drop = new DropOff(5, "TestCheckIn");
            CheckIn checkIn = new CheckIn(drop, "CheckIn", 1);
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);

            checkIn.PassBaggage(baggage);
            Assert.AreEqual(checkIn.baggage.Count, 0);
        }

        [TestMethod]
        public void PassBaggageTestNext()
        {
            DropOff drop = new DropOff(5, "TestCheckIn");
            CheckIn checkIn = new CheckIn(drop, "CheckIn", 1);
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);
            Conveyor conveyor = new Conveyor(drop, "Conv1");
            checkIn.next = conveyor;
            checkIn.PassBaggage(baggage);
            Assert.AreEqual(checkIn.baggage.Count, 0);
            Assert.AreEqual(conveyor.baggage.Count, 0);
        }
    }
}
