using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class MainProcessArea : Node
    {


        public MainProcessArea(string name)
        {
            this.Name = name;
        }


        public void PassBaggage(Baggage data)
        {
            if (next != null)
            {
                if (this.next is Conveyor)
                {
                    if ((this.next as Conveyor).DropOffGate == data.DropOffGate)
                    {

                        foreach (Baggage a in this.baggage)
                        {
                            if (a.DropOffGate == (this.next as Conveyor).DropOffGate)
                            {
                                this.next.baggage.Add(data);

                            }

                        }

                        //this.baggage.Remove(data);
                        Console.WriteLine($"Name: {this.Name} Number of baggages: {this.baggage.Count} has proccessed the baggage");
                    }
                }
            }
        }
    }
}
