using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class Airport
    {
        List<CheckIn> checkIns = new List<CheckIn>();
        List<Passenger> Passengers = new List<Passenger>();
        public List<Baggage> bags = new List<Baggage>();
        List<Ticket> ticketsSold = new List<Ticket>();
        List<DropOff> DropOffs;
        Random rnd = new Random();
        DropOff RandomDrop;
        
        //public void removeBagFromList(Baggage b)
        //{
        //    foreach (Baggage bag in bags)
        //    {
        //        if(bag == b)
        //        {
        //            bags.Remove(b);
        //        }
        //    }
        //}
        public Airport()
        {
           
            //create fixed dropoffs 
            DropOffs = new List<DropOff>()
            {
                 new DropOff(1, "drop1"),
                 new DropOff(2, "drop2"),
                 new DropOff(3, "drop3"),
                 new DropOff(4, "drop4")
                
            };

            //random values for passengers
            for (int i = 0; i < 50; i++)
            {
                Passengers.Add(new Passenger(i.ToString(), RandomDrop=DropOffs[rnd.Next(DropOffs.Count)]));

                bags.Add(new Baggage(RandomDrop, i, Passengers[i]));
            }

            //random values for bags
            //for (int i = 0; i < 50; i++)
            //{
                
            //}
            
        }

        public DropOff getDrop(string name)
        {
            DropOff dropy = null;
            foreach (DropOff d in DropOffs)
            {
                if(d.Name == name)
                {
                    dropy = d;
                }
            }
            return dropy;
        }

        public List<Baggage> getBagByDropOff(DropOff d)
        {
            List<Baggage> temp = new List<Baggage>();

            foreach (Baggage b in bags)
            {
                if (b.DropOffGate == d)
                {
                    temp.Add(b);
                }
            }
            return temp;
        }

        public void AddBag(Baggage bag)
        {
            bags.Add(bag);
        }

        public void addPassenger(Passenger p)
        {
            Passengers.Add(p);
        }
        public void buyTicket(Passenger p, double price, string flightNr)
        {
            Ticket t = new Ticket(flightNr, p, price);
            ticketsSold.Add(t);
        }

        public List<Passenger> getAllPassengers()
        {
            return Passengers;
        }

        public List<Passenger> getPassengers(DropOff d)
        {
            List<Passenger> temp = new List<Passenger>();
            foreach (Passenger passenger in Passengers)
            {
                if (passenger.flightDropOff == d)
                {
                    temp.Add(passenger);
                }
            }
            return temp;
        }


        public void addCheckin(CheckIn c)
        {
            checkIns.Add(c);
        }

        public int GetNumberOfChickIns(string dropoffName)
        {
            List<CheckIn> temp = new List<CheckIn>();
            foreach (CheckIn c in checkIns)
            {
                if (c.DestinationGate.Name == dropoffName)
                {
                    temp.Add(c);
                }
            }
            return temp.Count();
        }
        public int GetNumberOfTicketsSold(DropOff d)
        {
            List<Ticket> temp = new List<Ticket>();
            foreach (Ticket t in ticketsSold)
            {
                if (t.cust.flightDropOff == d)
                {
                    temp.Add(t);
                }
            }
            return temp.Count();
        }
    }
}
