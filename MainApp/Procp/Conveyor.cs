using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
    public class Conveyor : Node
    {
        public DropOff DropOffGate { get; set; }
        public int Number { get; set; }

        public bool IsBroken { get; set; }



        public Conveyor(DropOff destinationgate, string name)
        {
            this.DropOffGate = destinationgate;
            this.Name = name;
            Random random = new Random();
            Number = 2 ;
            //random.Next(0, 3)
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
                
                    if (this.baggage != null)
                    {
                        //this.baggage.Add(data);
                        //this.IsFree = true;
                        if (next != null)
                        {
                            //(next as Conveyor).PassBaggage(data);
                            if(next is Conveyor)
                            {
                                (next as Conveyor).PassBaggage(data);
                                this.baggage.Remove(data);
                                Console.WriteLine("Conveyor: {0}, Number: {1}" ,this.Name, this.baggage.Count);
                            }
                            else if(next is DropOff)
                            {
                                (next as DropOff).PassBaggage(data);
                                this.baggage.Remove(data);
                                Console.WriteLine("Conveyor: {0}, Number: {1}", this.Name, this.baggage.Count);
                            }
                            
                        }
                        
                    }
                


            }

        }

    }
}

