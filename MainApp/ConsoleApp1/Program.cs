using Procp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DropOff drop = new DropOff(5, "drop1");
            CheckIn check = new CheckIn(drop, "check1", 4);
            CheckIn check2 = new CheckIn(drop, "check2", 5);
            Conveyor conveyorl = new Conveyor(drop, "convl");
            Conveyor conveyorl1 = new Conveyor(drop, "convl1");
            Conveyor conveyorb2 = new Conveyor(drop, "convb");
            Conveyor conveyorb3 = new Conveyor(drop, "convb1");
            MainProcessArea mpa = new MainProcessArea("mpa1");

            LinkedList l = new LinkedList();
            LinkedList b = new LinkedList();
            l.AddLast(check);
            l.AddLast(conveyorl);
            //l.AddLast(mpa);
            l.AddLast(conveyorl1);
            l.AddLast(drop);

            b.AddLast(check2);
            b.AddLast(conveyorb2);
            //b.AddLast(mpa);
            b.AddLast(conveyorb3);
            b.AddLast(drop);

            Airport airport = new Airport();




            Baggage x = new Baggage(drop, 5, new Passenger("bag1", drop));
            Baggage xy = new Baggage(drop, 6, new Passenger("bag2", drop));
            l.PassBaggage(x);
            b.PassBaggage(xy);
            //Console.WriteLine(l.first.Name);
            //Console.WriteLine(l.first.Name);

            //l.printAllNodes();

            Console.ReadKey();
        }
    }
}
