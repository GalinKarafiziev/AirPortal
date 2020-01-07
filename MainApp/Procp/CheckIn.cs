using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class CheckIn : Node
    {
        public DropOff DestinationGate { get; set; }
        public Point Point { get; set; }
        public int Id { get; set; }
        public CheckIn(DropOff destination, string name, int id)
        {
            this.DestinationGate = destination;
            this.Name = name;
            this.Id = id;
        }

        public void PassBaggage(Baggage data)
        {
            if (this.DestinationGate == data.DropOffGate)
            {
                this.IsFree = false;
                this.baggage.Add(data);
                this.IsFree = true;
                if (next != null)
                {
                    next.baggage.Add(data);
                }
                //this.baggage.Remove(data);
                Console.WriteLine($"{this.Name} {this.baggage.Count} has proccessed the baggage");
            }
        }
    }
}
