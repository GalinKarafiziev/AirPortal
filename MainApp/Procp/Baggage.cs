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

        //timer is used to know which checkin should be used for the bag
        public int TimerId { get; set; }
        public bool ReachedDrop { get; set; }

        public Baggage(DropOff dropOffGate, int baggageNumber, Passenger passenger)
        {
            this.DropOffGate = dropOffGate;
            this.BaggageNumber = baggageNumber;
            this.passenger = passenger;
            this.Suspicious = false;
            this.IsOnConveyer = false;
            ReachedDrop = false;
            TimerId = 0;
        }
    }
}
