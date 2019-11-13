using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    class Airport
    {
        List<CheckIn> checkIns = new List<CheckIn>();
        List<Passenger> Passengers = new List<Passenger>();
        List<Baggage> bags = new List<Baggage>();

        public List<Baggage> getBagByDropOff(DropOff d)
        {
            List<Baggage> temp = new List<Baggage>();

            foreach (Baggage b in bags)
            {
                if(b.DropOffGate == d)
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
    }
}
