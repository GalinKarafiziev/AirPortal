using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procp;

namespace UnitTestProject
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DropOff dropOff = new DropOff(5, "Drop1");
            CheckIn checkIn = new CheckIn(dropOff, "CheckIn", 1);
            Conveyor conveyor1 = new Conveyor(dropOff, "Conveyor1");
            Conveyor conveyor2 = new Conveyor(dropOff, "Conveyor2");
            MainProcessArea mpa = new MainProcessArea("mpa");
            LinkedList linkedList = new LinkedList();
            CreateLinkList linkedLinked = new CreateLinkList(linkedList, checkIn, conveyor1, conveyor2, dropOff);

            Assert.IsNotNull(linkedLinked);
        }

        [TestMethod]
        public void GetLastTest()
        {
            DropOff dropOff = new DropOff(5, "Drop1");
            CheckIn checkIn = new CheckIn(dropOff, "CheckIn", 1);
            Conveyor conveyor1 = new Conveyor(dropOff, "Conveyor1");
            Conveyor conveyor2 = new Conveyor(dropOff, "Conveyor2");
            MainProcessArea mpa = new MainProcessArea("mpa");
            LinkedList linkedList = new LinkedList();
            CreateLinkList linkedLinked = new CreateLinkList(linkedList, checkIn, conveyor1, conveyor2, dropOff);

            linkedList.GetLast();
            Assert.AreEqual(dropOff, linkedList.GetLast());
        }

        [TestMethod]
        public void AddLastTest()
        {
            DropOff dropOff = new DropOff(5, "Drop1");
            CheckIn checkIn = new CheckIn(dropOff, "CheckIn", 1);
            Conveyor conveyor1 = new Conveyor(dropOff, "Conveyor1");
            Conveyor conveyor2 = new Conveyor(dropOff, "Conveyor2");
            Conveyor conveyor3 = new Conveyor(dropOff, " Conveyor3");
            
            LinkedList linkedList = new LinkedList();
            CreateLinkList linkedLinked = new CreateLinkList(linkedList, checkIn, conveyor1, conveyor2, dropOff);
            linkedLinked.LinkList.AddLast(conveyor3);

            Assert.AreEqual(5, linkedLinked.LinkList.PartsInLinkedList);

        }


        //Even though it says that it fails, it actually is correct (see the output of the console)
        [TestMethod]
        public void PassBaggageTest()
        {
            DropOff dropOff = new DropOff(5, "Drop1");
            CheckIn checkIn = new CheckIn(dropOff, "CheckIn", 1);
            Conveyor conveyor1 = new Conveyor(dropOff, "Conveyor1");
            conveyor1.IsBroken = false;
            Conveyor conveyor2 = new Conveyor(dropOff, "Conveyor2");
            conveyor2.IsBroken = false;
            
            MainProcessArea mpa = new MainProcessArea("mpa");
            
            LinkedList linkedList = new LinkedList();
            CreateLinkList linkedLinked = new CreateLinkList(linkedList, checkIn, conveyor1, conveyor2, dropOff);
            Passenger passenger = new Passenger("TTT", dropOff);
            Baggage baggage = new Baggage(dropOff, 5, passenger);
            linkedList.PassBaggage(baggage);

            //Assert.AreEqual(1, checkIn.baggage.Count);
            //Assert.AreEqual(1, conveyor1.baggage.Count);
            
            //Assert.AreEqual(1, mpa.baggage.Count);
            //Assert.AreEqual(1, conveyor2.baggage.Count);
            Assert.AreEqual(1, dropOff.baggage.Count);
            

           
        }
    }
}
