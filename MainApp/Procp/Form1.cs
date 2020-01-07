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
        CreateLinkList C1;
        CreateLinkList C2;
        CreateLinkList C3;
        CreateLinkList C4;
        //array to be checked
        Random rnd = new Random();
        List<int> numbersList = new List<int>();

        int nextDropD = 0;


        public Form1()
        {
            InitializeComponent();
        }
        //each checkIn has 2 timers one: if the drop is using one checkin and one if the drop is using two checkIns 
        public List<System.Windows.Forms.Timer> GetTimersBycheckInNum(int num)
        {
            List<System.Windows.Forms.Timer> timers = new List<System.Windows.Forms.Timer>();
            if (num == 1)
            {
                timers.Add(CheckIn1Timer);
                timers.Add(Check1NewCheckTimer);
            }
            else if (num == 2)
            {
                timers.Add(CheckIn2Timer);
                timers.Add(Check2NewCheckTimer);
            }
            else if (num == 3)
            {
                timers.Add(CheckIn3Timer);
                timers.Add(Check3NewCheckTimer);
            }
            else if (num == 4)
            {
                timers.Add(CheckIn4Timer);
                timers.Add(Check4NewCheckTimer);
            }
            return timers;
        }

        //if checkin has more then 50bags try to make use of another checkin
        public bool MoreThen50Bags(DropOff d, int checkInNum)
        {
            bool x = false;
            int bags = airport.getBagByDropOff(d).Count();
            if (bags < 10)
            {
                return x;
            }
            System.Windows.Forms.Timer FirstTimer;
            System.Windows.Forms.Timer SecondTimer;
            FirstTimer = GetTimersBycheckInNum(checkInNum)[0];
            SecondTimer = GetTimersBycheckInNum(checkInNum)[1];

            // check which checkin is not used
            if (btnCheckIn2.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn2 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    x = true;
                    d.UsedBy = 2;

                    FirstTimer.Enabled = false;

                    CreateCheckIn2(d);

                    airport.DevideBetween2Checks(d, checkInNum, 2);
                    SecondTimer.Tag = d;
                    SecondTimer.Interval = 1;
                    SecondTimer.Start();
                }
            }
            else if (btnCheckIn3.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn3 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    btnCheckIn3.Enabled = false;
                    x = true;
                    d.UsedBy = 3;
                    FirstTimer.Enabled = false;

                    lbDrop3.Text = d.Name;
                    comboBox3.Enabled = false;

                    airport.DevideBetween2Checks(d, checkInNum, 3);
                    SecondTimer.Tag = d;
                    SecondTimer.Interval = 1;
                    SecondTimer.Start();
                }
            }
            else if (btnCheckIn4.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn4 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    btnCheckIn4.Enabled = false;
                    x = true;
                    d.UsedBy = 4;
                    FirstTimer.Enabled = false;

                    lbDrop4.Text = d.Name;
                    comboBox4.Enabled = false;

                    airport.DevideBetween2Checks(d, checkInNum, 4);
                    SecondTimer.Tag = d;
                    SecondTimer.Interval = 1;
                    SecondTimer.Start();
                }
            }
            else
            {
                return false;
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
        public void bagMove(PictureBox p)
        {
            p.Top += 2;
        }

        public void CreateCheckIn1(DropOff d)
        {
            CheckIn checkIn1;
            checkIn1 = new CheckIn(d, "checkIn1", 1);
            airport.addCheckin(checkIn1);
            Conveyor conveyor1 = new Conveyor(d, "conv1");
            Conveyor conveyor2 = new Conveyor(d, "conv2");
            checkIn1.Point = new Point(205, 0);
            LinkedList link1 = new LinkedList();
            C1 = new CreateLinkList(link1, checkIn1, conveyor1, conveyor2, mpa, d);
            btnStart.Enabled = false;
            comboBox1.Enabled = false;
            lbDrop1.Text = d.Name;

        }


        public void CreateCheckIn2(DropOff d)
        {
            CheckIn checkIn2;
            checkIn2 = new CheckIn(d, "checkIn2", 2);
            airport.addCheckin(checkIn2);
            Conveyor conveyor3 = new Conveyor(d, "conv3");
            Conveyor conveyor4 = new Conveyor(d, "conv4");
            checkIn2.Point = new Point(365, 0);
            LinkedList link2 = new LinkedList();
            C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, d);
            btnCheckIn2.Enabled = false;
            comboBox2.Enabled = false;
            lbDrop2.Text = d.Name;
        }
        public void CreateCheckIn3(DropOff d)
        {
            CheckIn checkIn3 = new CheckIn(d, "checkIn3", 3);
            airport.addCheckin(checkIn3);

            Conveyor conveyor5 = new Conveyor(d, "conv5");
            Conveyor conveyor6 = new Conveyor(d, "conv6");
            checkIn3.Point = new Point(525, 0);
            LinkedList link3 = new LinkedList();
            C3 = new CreateLinkList(link3, checkIn3, conveyor5, conveyor6, mpa, d);
            btnCheckIn3.Enabled = false;
            comboBox3.Enabled = false;
            lbDrop3.Text = d.Name;
        }
        public void CreateCheckIn4(DropOff d)
        {
            CheckIn checkIn4 = new CheckIn(d, "checkIn4", 4);
            airport.addCheckin(checkIn4);
            Conveyor conveyor7 = new Conveyor(d, "conv7");
            Conveyor conveyor8 = new Conveyor(d, "conv8");
            checkIn4.Point = new Point(685, 0);
            LinkedList link4 = new LinkedList();
            C4 = new CreateLinkList(link4, checkIn4, conveyor7, conveyor8, mpa, d);
            btnCheckIn4.Enabled = false;
            comboBox4.Enabled = false;
            lbDrop4.Text = d.Name;
        }

        public void startCheckIn1(DropOff dr)
        {
            CreateCheckIn1(dr);

            bool more50 = MoreThen50Bags(dr, 1);
            if (more50 == false)
            {
                CheckIn1Timer.Tag = dr;
                CheckIn1Timer.Interval = 1;
                CheckIn1Timer.Start();
            }

            //CheckIn checkIn2 = new CheckIn(dr, "checkIn2", 2);
            //airport.addCheckin(checkIn2);
            //checkIn2.Point = new Point(525, 0);


        }
        public void startCheckIn3(DropOff dr)
        {
            CreateCheckIn3(dr);
            bool more50 = MoreThen50Bags(dr, 3);
            if (more50 == false)
            {
                CheckIn3Timer.Tag = dr;
                CheckIn3Timer.Interval = 1;
                CheckIn3Timer.Start();
            }

            //CheckIn checkIn3 = new CheckIn(dr, "checkIn2", 3);
            //airport.addCheckin(checkIn3);
            //checkIn3.Point = new Point(525, 0);
        }

        public void startCheckIn2(DropOff dr)
        {
            CreateCheckIn2(dr);
            bool more50 = MoreThen50Bags(dr, 2);
            if (more50 == false)
            {
                CheckIn2Timer.Tag = dr;
                CheckIn2Timer.Interval = 1;
                CheckIn2Timer.Start();
            }
        }

        public void startCheckIn4(DropOff dr)
        {
            CreateCheckIn4(dr);
            bool more50 = MoreThen50Bags(dr, 4);
            if (more50 == false)
            {
                CheckIn4Timer.Tag = dr;
                CheckIn4Timer.Interval = 1;
                CheckIn4Timer.Start();
            }
        }

        public void adder(DropOff DF)
        {
            DropOff d1 = airport.getDrop("drop1");
            DropOff d2 = airport.getDrop("drop2");
            DropOff d3 = airport.getDrop("drop3");
            if (DF == d1)
            {
                d1.CurrentBag++;
            }
            if (DF == d2)
            {
                d2.CurrentBag++;
            }
            if (DF == d3)
            {
                d3.CurrentBag++;
            }

        }

        public int checker(DropOff DF)
        {
            DropOff d1 = airport.getDrop("drop1");
            DropOff d2 = airport.getDrop("drop2");
            DropOff d3 = airport.getDrop("drop3");
            if (DF == d1)
            {
                return d1.CurrentBag;
            }
            if (DF == d2)
            {
                return d2.CurrentBag;
            }
            if (DF == d3)
            {
                return d3.CurrentBag;
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

                if (b.TimerId == 1)
                {
                    loc = new Point(205, 0);
                }
                else if (b.TimerId == 2)
                {
                    loc = new Point(365, 0);
                }
                else if (b.TimerId == 3)
                {
                    loc = new Point(525, 0);
                }
                else if (b.TimerId == 4)
                {
                    loc = new Point(685, 0);
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
                //goes to sized
                else if (!b.IsOnConveyer && b.Suspicious == true)
                {

                    PictureBox p = new PictureBox
                    {
                        Name = $"pictureBox{b.BaggageNumber}",
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(50, 55),
                        Location = new Point(20, 65),
                        BackColor = Color.DarkRed,
                    };
                    this.Controls.Add(p);
                    p.Click += this.PictureClick;
                }
            }
        }


        private void CheckIn1_Tick(object sender, EventArgs e)
        {
            DropOff drop = (DropOff)CheckIn1Timer.Tag;
            CheckIn ch = airport.GetCheckInById(1);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(drop.Number)[0];
            Label lbCheck = GetStatisticsLabels(drop.Number)[1];
            Label lbPassenger = GetStatisticsLabels(drop.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(drop).Count().ToString();
                lbPassenger.Text = airport.getPassengers(drop).Count().ToString();
                for (int j = 0; j < drop.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(drop)[j].BaggageNumber}" && airport.getBagByDropOff(drop)[j].Suspicious == false)
                    {
                        LinkedList link1 = C1.LinkList;

                        bagMove((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link1.PassBaggage(airport.getBagByDropOff(drop)[j]);
                            lbbags.Text = link1.getAllBags().Count().ToString();
                            airport.getBagByDropOff(drop)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(drop)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }
                    }
                }
            }
            int[] arrays = { 100, 150, 180 };
            if (drop.Count % arrays[nextDropD] == 0)
            {
                sendBag(drop, ch.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            drop.Count++;
        }

        private void btnCheckIn2_Click(object sender, EventArgs e)
        {

            DropOff drop = GetDropSelected(2);
            if (drop.UsedBy != 0)
            {
                airport.DevideBetween2Checks(drop, 2, drop.UsedBy);
                drop.UsedBy = 2;
                comboBox2.Items.RemoveAt(drop.Number);
            }
            else
            {


                drop.UsedBy = 2;
            }

            startCheckIn2(drop);
            CheckIn2Timer.Interval = 1;
            CheckIn2Timer.Tag = drop;
            CheckIn2Timer.Start();
            btnCheckIn2.Enabled = false;
        }
        private void CheckIn2_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn2Timer.Tag;
            CheckIn ch = airport.GetCheckInById(2);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();
                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C2.LinkList;
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = link.getAllBags().Count().ToString();
                                airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                                airport.getBagByDropOff(d)[j].ReachedDrop = true;
                                ((PictureBox)this.Controls[i]).Visible = false;
                            }
                        }
                    }
                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }

        //Slows down the bags in a specific speed
        private void button2_Click(object sender, EventArgs e)
        {
            CheckIn1Timer.Interval = 50;
            CheckIn2Timer.Interval = 50;
        }

        //returns the speed of the bags into the predifined speed
        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn1Timer.Interval = 1;
            CheckIn2Timer.Interval = 1;
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
            if (oPictureBox.Location == new Point(20, 65))
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
            lbtimerS.Text = b.TimerId.ToString();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {

            if (CheckIn1Timer.Enabled == false)
            {
                CheckIn1Timer.Interval = 1;
                CheckIn1Timer.Start();

                if (btnCheckIn2.Enabled == false)
                {
                    CheckIn2Timer.Interval = 1;
                    CheckIn2Timer.Start();
                }

            }
            else
            {
                CheckIn1Timer.Enabled = true;
                CheckIn1Timer.Stop();
                if (btnCheckIn2.Enabled == false)
                {
                    CheckIn2Timer.Enabled = true;
                    CheckIn2Timer.Stop();
                }

            }

        }

        private void Check1NewCheck_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)Check1NewCheckTimer.Tag;
            CheckIn ch1 = airport.GetCheckInById(1);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();

                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C1.LinkList;
                        bagMove((PictureBox)this.Controls[i]);

                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbbags.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(d)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }

                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch1.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            airport = new Airport();
            mpa = new MainProcessArea();
            btnStart.Enabled = false;
            DropOff drop = GetDropSelected(1);
            drop.UsedBy = 1;
            startCheckIn1(drop);

        }

        public List<Label> GetStatisticsLabels(int dropNumber)
        {
            List<Label> lbs = new List<Label>();
            if (dropNumber == 1)
            {
                lbs.Add(lbBags1);
                lbs.Add(lbCheckIn1);
                lbs.Add(lbPassenger1);

            }
            else if (dropNumber == 2)
            {
                lbs.Add(lbBags2);
                lbs.Add(lbCheckIn2);
                lbs.Add(lbPassenger2);

            }
            else if (dropNumber == 3)
            {
                lbs.Add(lbBags3);
                lbs.Add(lbCheckIn3);
                lbs.Add(lbPassenger3);
            }

            return lbs;
        }

        private DropOff GetDropSelected(int n)
        {
            //n is for which combox
            ComboBox cb = null;
            DropOff d = null;
            if (n == 1)
            {
                cb = comboBox1;
            }
            else if (n == 2)
            {
                cb = comboBox2;
            }
            else if (n == 3)
            {
                cb = comboBox3;
            }
            else if (n == 4)
            {
                cb = comboBox4;
            }

            //after gitting which combox now which drop 1||2||3
            if (cb.SelectedIndex == 0)
            {
                d = airport.getDrop("drop1");
            }
            else if (cb.SelectedIndex == 1)
            {
                d = airport.getDrop("drop2");
            }
            else if (cb.SelectedIndex == 2)
            {
                d = airport.getDrop("drop3");
            }
            return d;
        }

        private void Check2NewCheckTimer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)Check2NewCheckTimer.Tag;
            CheckIn ch2 = airport.GetCheckInById(2);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();

                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C2.LinkList;
                        bagMove((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbbags.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(d)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }

                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch2.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }

        private void btnCheckIn3_Click(object sender, EventArgs e)
        {
            DropOff drop = GetDropSelected(3);
            if (drop.UsedBy != 0)
            {
                airport.DevideBetween2Checks(drop, 3, drop.UsedBy);
                drop.UsedBy = 3;
            }
            else
            {
                drop.UsedBy = 3;
            }

            startCheckIn3(drop);
            CheckIn3Timer.Interval = 1;
            CheckIn3Timer.Tag = drop;
            CheckIn3Timer.Start();
            btnCheckIn3.Enabled = false;
        }

        private void btnCheckIn4_Click(object sender, EventArgs e)
        {
            DropOff drop = GetDropSelected(4);
            if (drop.UsedBy != 0)
            {
                airport.DevideBetween2Checks(drop, 4, drop.UsedBy);
                drop.UsedBy = 4;
            }
            else
            {
                drop.UsedBy = 4;
            }

            startCheckIn4(drop);
            CheckIn4Timer.Interval = 1;
            CheckIn4Timer.Tag = drop;
            CheckIn4Timer.Start();
            btnCheckIn4.Enabled = false;
        }

        private void CheckIn3Timer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn3Timer.Tag;
            CheckIn ch = airport.GetCheckInById(3);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();
                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C3.LinkList;
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = link.getAllBags().Count().ToString();
                                airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                                airport.getBagByDropOff(d)[j].ReachedDrop = true;
                                ((PictureBox)this.Controls[i]).Visible = false;
                            }
                        }
                    }
                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }

        private void CheckIn4Timer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn4Timer.Tag;
            CheckIn ch = airport.GetCheckInById(4);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();
                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C4.LinkList;
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = link.getAllBags().Count().ToString();
                                airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                                airport.getBagByDropOff(d)[j].ReachedDrop = true;
                                ((PictureBox)this.Controls[i]).Visible = false;
                            }
                        }
                    }
                }
            }

            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }

        private void Check3NewCheckTimer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)Check3NewCheckTimer.Tag;
            CheckIn ch3 = airport.GetCheckInById(3);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();

                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C3.LinkList;
                        bagMove((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbbags.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(d)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }

                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch3.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }

        private void Check4NewCheckTimer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)Check4NewCheckTimer.Tag;
            CheckIn ch4 = airport.GetCheckInById(4);

            //getting statistics lables 
            Label lbbags = GetStatisticsLabels(d.Number)[0];
            Label lbCheck = GetStatisticsLabels(d.Number)[1];
            Label lbPassenger = GetStatisticsLabels(d.Number)[2];

            for (int i = 0; i < this.Controls.Count; i++)
            {
                lbCheck.Text = airport.GetCheckInForDrops(d).Count().ToString();
                lbPassenger.Text = airport.getPassengers(d).Count().ToString();

                for (int j = 0; j < d.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false)
                    {
                        LinkedList link = C4.LinkList;
                        bagMove((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link.PassBaggage(airport.getBagByDropOff(d)[j]);
                            lbbags.Text = link.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(d)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }

                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d.Count % arrays[nextDropD] == 0)
            {
                sendBag(d, ch4.Point);
                Random random = new Random();
                nextDropD = random.Next(0, 2);
            }
            d.Count++;
        }
    }
}
