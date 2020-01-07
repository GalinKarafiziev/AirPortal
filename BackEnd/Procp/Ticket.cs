using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    class Ticket
    {
       public string FlightNr { get; set; }
       public Passenger cust;
       public double price { get; set; }
       
       public Ticket (string flightnr, Passenger cust, double price)
        {
            this.FlightNr = flightnr;
            this.cust = cust;
            this.price = price;
        }
    }
}
