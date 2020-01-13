using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
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
            if (!(this.baggage.Contains(data))){
                this.baggage.Add(data);
            }
            
            Console.WriteLine("Dropoff: {0}, Number: {1}", this.Name, this.baggage.Count);



        }

    }
}
