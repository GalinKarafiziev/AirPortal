using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procp;

namespace UnitTestProject
{
    [TestClass]
    public class ConveyorTest
    {
        [TestMethod]
        public void ConveyorInitialisation()
        {
            DropOff drop = new DropOff(5, "Drop1" );
            Conveyor conv = new Conveyor(drop, "Conv1");
            conv.Number = 0;

            Assert.AreEqual(conv.Number, 0);
        }
        [TestMethod]
        public void ConveyorPassBaggage()
        {
            
            DropOff drop = new DropOff(5, "Drop1");
            Conveyor conv = new Conveyor(drop, "Conv1");
            conv.IsBroken = false;
            Conveyor conv1 = new Conveyor(drop, "Conv2");
            conv1.IsBroken = false;
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);
            conv.next = conv1;
            conv.PassBaggage(baggage);
            
            Assert.AreEqual(conv1.baggage.Count, 1);

        }

        [TestMethod]
        public void ConveyorPassBaggageBroken()
        {
            DropOff drop = new DropOff(5, "Drop1");
            Conveyor conv = new Conveyor(drop, "Conv1");
            
            conv.IsBroken = true;
            Conveyor conv1 = new Conveyor(drop, "Conv2");
            
            conv1.IsBroken = false;
            Passenger passenger = new Passenger("111", drop);
            Baggage baggage = new Baggage(drop, 50, passenger);
            conv.next = conv1;
            conv.PassBaggage(baggage);

            //Assert.AreEqual(0, conv.Number);
            Assert.AreEqual(true, conv.IsBroken);
            Assert.AreEqual(0, conv1.baggage.Count);
        }
    }
}
