using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procp
{
    public partial class Form1 : Form
    {
        Airport airport;
        MainProcessArea mpa;
        DropOff d1;
        CreateLinkList C1;
        CreateLinkList C2;
        //array to be checked
        Random rnd = new Random();
        List<int> numbersList = new List<int>();

        //for dropOff1
        int countD1 = 0;
        int nextDropD1 = 0;

        
        public Form1()
        {
            InitializeComponent();
            airport = new Airport();
            mpa = new MainProcessArea();
            
            d1 = airport.getDrop("drop1");
            startDropOff1();
            airport.GetAllBags();

        }

        //if checkin has more then 50bags try to make use of another checkin
        public string MoreThen50Bags(DropOff d)
        {
            string x= "";
            int bags = airport.getBagByDropOff(d).Count();
            if (bags < 10)
            {
                return "";
            }
            
            //first let's check if the second checkin is used
            if(btnCheckIn2.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Are you sure?", "Make use of checkIn2 for "+d.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    btnCheckIn2.Enabled = false;
                    x = "checkIn2";

                }
                else
                {
                    return "";
                }

            }
            return x;
        }
        //Populate array to be checked
        public void PopulateArraylist()
        {
            for (int i = 0; i < 5; i++)
            {
                int rndNr = rnd.Next(1, 10) - 1;
                numbersList.Add(rndNr);
            }
        }
        public void bagMoveD1(PictureBox p)
        {
            if (p.Top < 160)
            {
                p.Top += 2;

            }
            else if (p.Top < 390 && p.Left > 205)
            {
                p.Left -= 2;

            }
            else
            {
                if (p.Top > 390 && p.Left > 205)
                {
                    p.Left -= 2;

                }
                else
                {
                    p.Top += 2;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void startDropOff1()
        {
            //For dropOff1
            CheckIn checkIn1 = new CheckIn(d1, "checkIn1",1);
            airport.addCheckin(checkIn1);
            Conveyor conveyor1 = new Conveyor(d1, "conv1");
            Conveyor conveyor2 = new Conveyor(d1, "conv2");
            checkIn1.Point = new Point(205, 0);

            LinkedList link1 = new LinkedList();
            C1 = new CreateLinkList(link1, checkIn1, conveyor1, conveyor2, mpa, d1);
            string more50 = MoreThen50Bags(d1);
            if(more50 == "checkIn2")
            {
                CheckIn1.Enabled = false;
                btnCheckIn2.Enabled = false;

                CheckIn checkIn2 = new CheckIn(airport.getDrop("drop1"), "checkIn2",2);
                airport.addCheckin(checkIn2);
                checkIn2.Point = new Point(525, 0);
                lbDrop2.Text = "DROP OFF1";

                //assgin the timerusage for each bag between 1&2
                foreach (Baggage B in airport.getBagByDropOff(d1))
                {
                    B.TimerId = rnd.Next(1, 3);
                }
                drop1NewCheck.Tag = d1;
                drop1NewCheck.Interval = 1;
                drop1NewCheck.Start();
            }
            else
            {
                CheckIn1.Interval = 1;
                CheckIn1.Start();
            }
            

        }

        public void startCheckIn2(string dropName)
        {
            //For dropOff2
            CheckIn checkIn2 = new CheckIn(airport.getDrop(dropName), "checkIn2",2);
            airport.addCheckin(checkIn2);
            DropOff drop = airport.getDrop(dropName);
            Conveyor conveyor3 = new Conveyor(drop, "conv3");
            Conveyor conveyor4 = new Conveyor(drop, "conv4");
            checkIn2.Point = new Point(525, 0);
            LinkedList link2 = new LinkedList();

            if(drop.Number == 2)
            {
                C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, drop);
            }
            //foreach (Baggage B in airport.getBagByDropOff(drop))
            //{
            //    B.TimerId = rnd.Next(1, 2);
            //}

        }

        public void adder(DropOff DF)
        {
            DropOff d2 = airport.getDrop("drop2");
            if (DF == d1)
            {
                d1.CurrentBag++;
            }
            if (DF == d2)
            {
                d2.CurrentBag++;
            }

        }

        public int checker(DropOff DF)
        {
            DropOff d2 = airport.getDrop("drop2");
            if (DF == d1)
            {
                return d1.CurrentBag;
            }
            if (DF == d2)
            {
                return d2.CurrentBag;
            }
            return 0;
        }

        private void sendBag(DropOff d, Point loc)
        {
            int currentb = checker(d);
            if (currentb < airport.getBagByDropOff(d).Count)
            {
                Baggage b = airport.getBagByDropOff(d)[currentb];
                //Check if the bag should go to SEIZED
                 string temp = b.BaggageId.Substring(b.BaggageId.Length - 1, 1);
                int x = 0;
                Int32.TryParse(temp, out x);
                //checking if statement
                if (numbersList.Contains(x))
                {
                    int arrayPos = 0;
                    foreach (var t in numbersList.ToList())
                    {
                        if (x == numbersList[arrayPos])
                        {
                            numbersList.RemoveAt(arrayPos);
                            b.Suspicious = true;
                        }
                        else
                        {
                            arrayPos++;
                        }
                    }
                }
                //if the array to be checked is empty - repopulate it
                if (numbersList.Count == 0)
                {
                    PopulateArraylist();
                }
                //if loc = 1,2 means drop1 is using checkin 1&2
                if(loc == new Point(1, 2))
                {
                    if(b.TimerId == 1)
                    {
                        loc = new Point(205, 0);
                    }
                    if(b.TimerId == 2)
                    {
                        loc = new Point(525, 0);
                    }
                }
                

                adder(d);
                if (!b.IsOnConveyer && b.Suspicious == false)
                {
                    PictureBox p = new PictureBox
                    {
                        Name = $"pictureBox{b.BaggageNumber}",
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(50, 55),
                        Location = loc,
                        BackColor = Color.Black,
                        

                    };
                    this.Controls.Add(p);
                    b.IsOnConveyer = true;
                    p.Click += this.PictureStatisticsClick;
                }
                else if (!b.IsOnConveyer && b.Suspicious == true)
                {

                    PictureBox p = new PictureBox
                    {
                        Name = $"pictureBox{b.BaggageNumber}",
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(50, 55),
                        Location = new Point(20,65),
                        BackColor = Color.DarkRed,
                    };
                    this.Controls.Add(p);
                    p.Click += this.PictureClick;
                }
            }
        }
        
      
        private void CheckIn1_Tick(object sender, EventArgs e)
        {
            CheckIn ch = airport.GetCheckInById(1);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheckIn.Text = airport.GetCheckInForDrops(d1).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d1).Count().ToString();
                for (int j = 0; j < d1.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d1)[j].BaggageNumber}" && airport.getBagByDropOff(d1)[j].Suspicious == false )
                    {
                        bagMoveD1((PictureBox)this.Controls[i]);
                        LinkedList link1 = C1.LinkList;
                        bagMoveD1((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link1.PassBaggage(airport.getBagByDropOff(d1)[j]);
                            lbBags.Text = link1.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d1)[j].IsOnConveyer = false;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }
                    }
                }
            }
            int[] arrays = { 100, 150, 180 };
            if (countD1 % arrays[nextDropD1] == 0)
            {
                sendBag(d1, ch.Point);
                Random random = new Random();
                nextDropD1 = random.Next(0, 2);
            }
            countD1++;


        }

        //checkIn2
        private void btnCheckIn2_Click(object sender, EventArgs e)
        {
            startCheckIn2("drop2");
            CheckIn2.Interval = 1;
            CheckIn2.Tag = airport.getDrop("drop2"); ;
            CheckIn2.Start();
            btnCheckIn2.Enabled = false;
        }

        public void bagMoveD2(PictureBox p)
        {
            if (p.Top < 165)
            {
                p.Top += 2;
            }
            else
            {
                if (p.Top > 390 && p.Left < 525)
                {
                    p.Left += 2;
                }
                else
                {
                    p.Top += 2;
                }
            }
        }

        public void bagMoveD3(PictureBox p)
        {
            if (p.Top < 165)
            {
                p.Top += 2;
            }
            else
            {
                if (p.Top > 390 && p.Left < 365)
                {
                    p.Left += 2;
                }
                else
                {
                    p.Top += 2;
                }
            }
        }

        
        private void CheckIn2_Tick(object sender, EventArgs e)
        {
            DropOff d =(DropOff) CheckIn2.Tag;
            CreateLinkList c = null;
            CheckIn ch = airport.GetCheckInById(2);
            
            if(d.Number == 1)
            {
                c = C1;
            }
            if(d.Number == 2)
            {
                c = C2;
            }
            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheckIn2.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger2.Text = airport.getPassengers(d).Count().ToString();
                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = c.LinkList;
                        bagMoveD2((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbBags2.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }
                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD1] == 0)
            {
                sendBag(d, ch.Point);
                Random random = new Random();
                nextDropD1 = random.Next(0, 2);
            }
            d.Count++;
        }

        //Slows down the bags in a specific speed
        private void button2_Click(object sender, EventArgs e)
        {
            CheckIn1.Interval = 50;
            CheckIn2.Interval = 50;
        }

        //returns the speed of the bags into the predifined speed
        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn1.Interval = 1;
            CheckIn2.Interval = 1;
        }
 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myBlackPen = new Pen(Color.Gray); // Pen: Draws the border around a shape
            Pen myWhitePen = new Pen(Color.White);

            SolidBrush myBlackBrush = new SolidBrush(Color.Black); // Brush: Paints the interior of a shape
            SolidBrush myBlueBrush = new SolidBrush(Color.MediumAquamarine);// Brush: Paints the interior of a shape
            SolidBrush myGrayBrush = new SolidBrush(Color.DarkRed);
            SolidBrush myWhiteBrush = new SolidBrush(Color.White);

            Rectangle[] rectangles =  {
                new Rectangle(0, 50, 90, 90), //Security down1
                new Rectangle(185, 50, 90, 500), //checkin1 to dropoff1
                new Rectangle(345, 50, 90, 500), //checkin2 to dropoff2
                new Rectangle(505, 50, 90, 500), //checkin3 to dropoff3
                new Rectangle(665, 50, 90, 500), //checkin4 to dropoff4
                new Rectangle(185, 130, 500, 100), //bellow all checkins
                new Rectangle(185, 230, 560, 225), //MPA
            };
            e.Graphics.DrawRectangles(myBlackPen, rectangles); //Draw conveyer
            for (int i = 0; i < rectangles.Length; i++)//color inside the rectangles
            {
                e.Graphics.FillRectangle(myWhiteBrush, rectangles[i]);
            }

            //color the checkins and seized and security
            Rectangle[] checkins =  {
                new Rectangle(185, 0, 90, 50), //checkin1 
                new Rectangle(345, 0, 90, 50), //checkin2 
                new Rectangle(505, 0, 90, 50), //checkin3 
                new Rectangle(665, 0, 90, 50), //checkin4 
                new Rectangle(0, 0, 90, 50), //Seized
            };
            e.Graphics.DrawRectangles(myBlackPen, checkins); //Draw check in
            for (int i = 0; i < checkins.Length; i++)
            {
                e.Graphics.FillRectangle(myBlueBrush, checkins[i]);
            }

            Rectangle[] sidebars =  {
                new Rectangle(0, 50, 10, 90),
                new Rectangle(0, 130, 90, 10),
                new Rectangle(80, 0, 10, 140),
                new Rectangle(185, 50, 10, 500),
                new Rectangle(265, 50, 10, 85),
                new Rectangle(265, 450, 10, 100),
                new Rectangle(265, 125, 89, 10),
                new Rectangle(265, 450, 90, 10),
                new Rectangle(345, 50, 10, 85),
                new Rectangle(345, 450, 10, 170),
                new Rectangle(425, 50, 10, 85),
                new Rectangle(425, 450, 10, 170),
                new Rectangle(435, 125, 79, 10),
                new Rectangle(435, 450, 80, 10),
                new Rectangle(505, 450, 10, 170),
                new Rectangle(505, 50, 10, 85),
                new Rectangle(585, 50, 10, 85),
                new Rectangle(585, 450, 10, 170),
                new Rectangle(595, 125, 79, 10),
                new Rectangle(595, 450, 80, 10),
                new Rectangle(665, 50, 10, 85),
                new Rectangle(665, 450, 10, 170),
                new Rectangle(745, 50, 10, 500),
            };
            e.Graphics.DrawRectangles(myBlackPen, sidebars); //Draw sidebars
            for (int i = 0; i < sidebars.Length; i++)//Fill sidebars with color
            {
                e.Graphics.FillRectangle(myBlueBrush, sidebars[i]);
            }
        }

        public void Seized(DropOff d, PictureBox pb, Baggage b)
        {
            Controls.Remove(pb);
            Baggage bag = new Baggage(b.DropOffGate, b.BaggageNumber, b.passenger);
            bag.TimerId = b.TimerId;
            bag.BaggageId = b.BaggageId;
            airport.AddBag(bag);
        }

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            Baggage b = airport.GetBagFromStringNum(oPictureBox.Name);
            if (oPictureBox.Location == new Point(20,65))
            {
                Seized(b.DropOffGate, oPictureBox, b);
            }
            
        }
        private void PictureStatisticsClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            Baggage b = airport.GetBagFromStringNum(oPictureBox.Name);
            lbDropOffDes.Text = b.DropOffGate.Name;
            lbTicketId.Text = b.passenger.TicketId;
            lbBaggy.Text = b.BaggageId;


        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            
            if(CheckIn1.Enabled == false)
            {
                CheckIn1.Interval = 1;
                CheckIn1.Start();

                if(btnCheckIn2.Enabled == false)
                {
                    CheckIn2.Interval = 1;
                    CheckIn2.Start();
                }
                
            }
            else
            {
                CheckIn1.Enabled = true;
                CheckIn1.Stop();
                if(btnCheckIn2.Enabled == false)
                {
                    CheckIn2.Enabled = true;
                    CheckIn2.Stop();
                }
                
            }
            
        }

        private void drop1NewCheck_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)drop1NewCheck.Tag;
            CheckIn selectedCheck = airport.GetCheckInById(1);
            CheckIn ch1 = airport.GetCheckInById(1);
            CheckIn ch2 = airport.GetCheckInById(2);

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheckIn.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();

                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C1.LinkList;
                        if(airport.getBagByDropOff(d)[j].TimerId == 1)
                        {
                            bagMoveD1((PictureBox)this.Controls[i]);
                            selectedCheck = ch1;
                        }
                        if (airport.getBagByDropOff(d)[j].TimerId == 2)
                        {
                            bagMoveD2((PictureBox)this.Controls[i]);
                            selectedCheck = ch2;
                        }

                        
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbBags.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }
                        
                    }
                    
                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD1] == 0)
            {
                sendBag(d, new Point(1,2));
                Random random = new Random();
                nextDropD1 = random.Next(0, 2);
            }
            d.Count++;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
