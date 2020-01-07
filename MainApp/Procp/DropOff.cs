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
        public int UsedBy { get; set; }


        public DropOff(int number, string name)
        {
            this.Number = number;
            this.Name = name;
            Count = 0;
            CurrentBag = 0;
            UsedBy = 0;
        }

        public void PassBaggage(Baggage data)
        {


            Console.WriteLine($"{this.Name} has proccessed the baggage Number: {this.baggage.Count}");
            foreach (Baggage a in this.baggage)
            {
                Console.WriteLine(a.passenger.TicketId);
            }

        }

    }
}
