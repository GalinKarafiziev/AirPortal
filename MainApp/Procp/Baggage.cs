using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Procp
{
    
    public class Baggage
    {
        private Random random = new Random();
        public DropOff DropOffGate { get; set; }
        public int BaggageNumber { get; set; }
        public Passenger passenger { get; set; }
        public string BaggageId { get; set; }
        public Boolean Suspicious { get; set; }
        public bool IsOnConveyer { get; set; }
        public Baggage(DropOff dropOffGate, int baggageNumber, Passenger passenger)
        {
            this.DropOffGate = dropOffGate;
            this.BaggageNumber = baggageNumber;
            this.passenger = passenger;
            this.Suspicious = false;
        }
    }
}
