using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class Baggage
    {
        public DropOff DropOffGate { get; set; }
        public int BaggageNumber { get; set; }
        public Passenger passenger { get; set; }
        public string BaggageId { get; }
        public Boolean Suspicious { get; set; }

        public bool IsOnConveyer { get; set; }
        public Baggage(DropOff dropOffGate, int baggageNumber, Passenger passenger)
        {

            Random random = new Random();
            string r = "";
            int i;
            for (i = 0; i < 7; i++)
            {
                r += random.Next(0, 9).ToString();
            }

            this.DropOffGate = dropOffGate;
            this.BaggageNumber = baggageNumber;
            this.passenger = passenger;
            this.BaggageId = "EIN" + r;
            this.Suspicious = false;
        }
    }
}
