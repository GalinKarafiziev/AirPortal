using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    class Conveyor : Node
    {
        public DropOff DropOffGate { get; set; }
        public int Number { get; set; }

        public bool IsBroken { get; set; }



        public Conveyor(DropOff destinationgate)
        {
            this.DropOffGate = destinationgate;
            Random random = new Random();
            Number = random.Next(0, 3);
            Broken();
        }


        public void Broken()
        {
            if (this.Number == 0)
            {
                this.IsBroken = true;
            }
            else
            {
                this.IsBroken = false;
            }
        }

        public void PassBaggage(Baggage data)
        {
            if (data.DropOffGate == this.DropOffGate)
            {
                if (!IsBroken)
                {
                    if (this.baggage != null)
                    {

                        this.IsFree = true;
                        if (next != null)
                        {
                            next.baggage.Add(data);
                        }
                        //this.baggage.Remove(data);
                        Console.WriteLine($"{this.Name} {this.baggage.Count} has proccessed the baggage");
                        Console.WriteLine($"{this.Number}");
                    }
                }
                else
                {
                    Console.WriteLine("LEAN");
                }


            }

        }

    }
}

