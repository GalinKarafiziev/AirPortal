using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
    public class Airport
    {
        List<CheckIn> checkIns = new List<CheckIn>();
        List<Passenger> Passengers = new List<Passenger>();
        public List<Baggage> bags = new List<Baggage>();
        List<Ticket> ticketsSold = new List<Ticket>();

        //listOfCreatedLinkLists
        List<CreateLinkList> lists = new List<CreateLinkList>();

        List<DropOff> DropOffs;
        Random rnd = new Random();
        DropOff RandomDrop;
        Random nig = new Random();


        public Airport()
        {

            //create fixed dropoffs 
            DropOffs = new List<DropOff>()
            {
                 new DropOff(1, "drop1"),
                 new DropOff(2, "drop2"),
                 new DropOff(3, "drop3")

            };

            //random values for passengers
            for (int i = 0; i < 100; i++)
            {
                Passengers.Add(new Passenger(i.ToString(), RandomDrop = DropOffs[rnd.Next(DropOffs.Count)]));
                Baggage b = new Baggage(RandomDrop, i, Passengers[i]);

                string r = "";

                for (int q = 0; q < 7; q++)
                {
                    r += nig.Next(0, 9).ToString();
                }
                b.BaggageId = "EIN" + r;
                bags.Add(b);
            }
        }

        public List<Baggage> GetAllBags()
        {
            return bags;
        }

        public DropOff getDrop(string name)
        {
            DropOff dropy = null;
            foreach (DropOff d in DropOffs)
            {
                if (d.Name == name)
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

        public Baggage GetBaggageByNumber(int bagNmbr)
        {

            foreach (Baggage bag in bags)
            {
                if (bag.BaggageNumber == bagNmbr)
                {
                    return bag;
                }
            }
            return null;
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

        public Baggage GetBagFromStringNum(string PicBoxName)
        {
            Baggage b = null;
            string[] number = Regex.Split(PicBoxName, @"\D+");
            int i = int.Parse(number[1]);

            foreach (Baggage bag in bags)
            {
                if (bag.BaggageNumber == i)
                {
                    b = bag;
                }
            }

            return b;
        }

        public CheckIn GetCheckInById(int num)
        {
            CheckIn ch = null;
            foreach (CheckIn c in checkIns)
            {
                if (c.Id == num)
                {
                    ch = c;
                }
            }
            return ch;
        }

        public List<CheckIn> GetCheckInForDrops(DropOff d)
        {
            List<CheckIn> ch = new List<CheckIn>();
            foreach (CheckIn c in checkIns)
            {
                if (c.DestinationGate == d)
                {
                    ch.Add(c);
                }
            }
            return ch;
        }

        //in case using 2 checkIns for the same drop off
        public void DevideBetween2Checks(DropOff d, int a, int b)
        {
            int[] nums = new int[2];
            nums[0] = a;
            nums[1] = b;
            int ran;
            //assgin the timerusage for each bag between a&b
            foreach (Baggage B in getBagByDropOff(d))
            {
                if (B.ReachedDrop == false)
                {
                    ran = rnd.Next(0, 2);
                    B.TimerId = nums[ran];
                }

            }
        }

        public void AssignTimerToBags(int timerId,DropOff d)
        {
            foreach (Baggage b in getBagByDropOff(d))
            {
                b.TimerId = timerId;
            }
        }

        public List<Baggage> getBagsWithTimerId(int t)
        {
            List<Baggage> temp = new List<Baggage>();
            foreach (Baggage b in bags)
            {
                if(b.TimerId == t)
                {
                    temp.Add(b);
                }
            }

            return temp;
        }

        //add linklist to lists
        public void addLinkList(CreateLinkList l)
        {
            lists.Add(l);
        }

        //get linklist according to the checkin number
        public CreateLinkList getCLinkList(int checkinNum)
        {
            CreateLinkList c = null;
            foreach (CreateLinkList cl in lists)
            {
                if(cl.CheckIn.Id == checkinNum)
                {
                    c = cl;
                }
            }
            return c;
        }


    }
}
