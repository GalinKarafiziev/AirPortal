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
            Conveyor conveyor = new Conveyor(drop, "conv2");
            Conveyor conveyor1 = new Conveyor(drop, "conv3");
            Conveyor conveyor2 = new Conveyor(drop, "conv4");
            Conveyor conveyor3 = new Conveyor(drop, "conv5");
            MainProcessArea mpa = new MainProcessArea("mpa1");

            LinkedList l = new LinkedList();
            LinkedList b = new LinkedList();
            l.AddLast(check);
            l.AddLast(conveyor);
            l.AddLast(mpa);
            l.AddLast(conveyor1);
            l.AddLast(drop);

            b.AddLast(check2);
            b.AddLast(conveyor2);
            b.AddLast(mpa);
            b.AddLast(conveyor3);
            b.AddLast(drop);

            Airport airport = new Airport();
            

            

            Baggage x = new Baggage(drop, 5, new Passenger("sdfdsf", drop));
            Baggage xy = new Baggage(drop, 6, new Passenger("ssf", drop));
            l.PassBaggage(x);
            b.PassBaggage(xy);
            Console.WriteLine(drop.baggage.Count);
            Console.ReadKey();
        }
    }
}
