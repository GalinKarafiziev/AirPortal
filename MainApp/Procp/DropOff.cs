using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class DropOff : Node
    {
        public int Number { get; set; }
        public int Count { get; set; }
        public int CurrentBag { get; set; }
        public Point Point { get; set; }

        public DropOff(int number ,string name)
        {
            this.Number = number;
            this.Name = name;

        }

        public void PassBaggage(Baggage data)
        {


            Console.WriteLine($"{this.Name} has proccessed the baggage");
            Console.WriteLine($"{this.baggage.Count} ");
        }

    }
}
