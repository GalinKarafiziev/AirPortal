using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class Passenger
    {
        public string TicketId { get; set; }
        public DropOff flightDropOff { get; set; }

        public Passenger(string ticketId, DropOff flightId)
        {
            this.TicketId = ticketId;
            this.flightDropOff = flightId;

        }

    }
}
