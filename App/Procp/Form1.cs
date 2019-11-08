using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Procp
{
    public partial class Form1 : Form
    {
        Airport airport;
        public Form1()
        {
            InitializeComponent();
            airport = new Airport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DropOff dropOff1 = new DropOff(5);
            dropOff1.Name = "drop1";

            CheckIn checkIn1 = new CheckIn(dropOff1);
            checkIn1.Name = "checkIn 1";
            airport.addCheckin(checkIn1);    
            Conveyor conveyor1 = new Conveyor(dropOff1);
            conveyor1.Name = "conv1";
            Conveyor conveyor3 = new Conveyor(dropOff1);
            conveyor3.Name = "conv3";

            DropOff dropOff2 = new DropOff(6);
            dropOff2.Name = "drop2";

            CheckIn checkIn2 = new CheckIn(dropOff2);
            checkIn2.Name = "check2";
            airport.addCheckin(checkIn2);
            Conveyor conveyor2 = new Conveyor(dropOff2);
            conveyor2.Name = "conv2";
            Conveyor conveyor4 = new Conveyor(dropOff2);
            conveyor4.Name = "conv4";



            
            
            MainProcessArea mpa = new MainProcessArea();
            mpa.Name = "mpa";

            DropOff drop3 = new DropOff(3);
            drop3.Name = "drop 3";

            CheckIn check3 = new CheckIn(drop3);
            check3.Name = "check 3";
            airport.addCheckin(check3);
            Conveyor conv6 = new Conveyor(drop3);
            conv6.Name = "conv6";
            Conveyor conv8 = new Conveyor(drop3);
            conv8.Name = "conv8";

            



            LinkedList system = new LinkedList();
            LinkedList sys = new LinkedList();
            LinkedList syss = new LinkedList();

            Passenger a = new Passenger("34sa6etr7",dropOff1);
            airport.addPassenger(a);

            Baggage baggage = new Baggage(dropOff1, 1,a);

            Passenger b = new Passenger("3f45frg83", dropOff1);
            airport.addPassenger(b);
            Baggage baggage1 = new Baggage(dropOff1, 3,b);

            Passenger c = new Passenger("5br467hg", dropOff2);
            airport.addPassenger(c);
            Baggage bag2 = new Baggage(dropOff2, 2, c);

            Passenger d = new Passenger("5br467hg", drop3);
            airport.addPassenger(d);
            Baggage bag3 = new Baggage(drop3, 2,d);
            




            system.AddLast(checkIn1);
            system.AddLast(conveyor1);
            system.AddLast(mpa);
            system.AddLast(conveyor3);
            system.AddLast(dropOff1);

            syss.AddLast(check3);
            syss.AddLast(conv6);
            syss.AddLast(mpa);
            syss.AddLast(conv8);
            syss.AddLast(drop3);




            sys.AddLast(checkIn2);
            sys.AddLast(conveyor2);
            sys.AddLast(mpa);
            sys.AddLast(conveyor4);
            sys.AddLast(dropOff2);

            system.PassBaggage(baggage);
            system.PassBaggage(baggage1);
            sys.PassBaggage(bag2);
            syss.PassBaggage(bag3);

            Console.ReadLine();

            
            
            gbDropoff1.Text =  dropOff1.Name.ToString();
            lbCheckIn.Text = airport.GetNumberOfChickIns(gbDropoff1.Text).ToString();
            lbBags.Text = sys.getAllBags().Count().ToString();
            lbPassenger.Text = airport.getPassengers(dropOff1).Count().ToString();


        }
    }
}
