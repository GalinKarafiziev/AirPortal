using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    class DropOff : Node
    {
        public int Number { get; set; }


        public DropOff(int number)
        {
            this.Number = number;

        }

        public void PassBaggage(Baggage data)
        {


            Console.WriteLine($"{this.Name} has proccessed the baggage");
            Console.WriteLine($"{this.baggage.Count}");
        }
    }
}
