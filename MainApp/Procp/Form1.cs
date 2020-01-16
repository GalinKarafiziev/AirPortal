using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        //array to be checked
        Random rnd = new Random();
        List<int> numbersList = new List<int>();
        List<Baggage> serializedBaggages;
        
        int nextDropD = 0;


        public Form1()
        {
            InitializeComponent();
            serializedBaggages = new List<Baggage>();
            airport = new Airport();
            UpdateComboBoxes();
            
            
        }

        //if checkin has more then 50bags try to make use of another checkin
        public bool MoreThen50Bags(DropOff d, int checkInNum)
        {
            bool x = false;
            int bags = airport.getBagByDropOff(d).Count();
            //if bags are less then 10 then just return 
            if (bags < 10)
            {
                return x;
            }

            // check which checkin is not used
            if (btnCheckIn2.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn2 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    x = true;
                    d.UsedBy = 2;
                    //CheckIn maincheck = airport.GetCheckInById(checkInNum);
                    CreateCheckIn2(d);

                    //CheckIn checkIn2;
                    //checkIn2 = new CheckIn(d, "checkIn2", 2);
                    //airport.addCheckin(checkIn2);
                    //Conveyor conveyor3 = new Conveyor(d, "conv3");
                    //Conveyor conveyor4 = new Conveyor(d, "conv4");
                    //checkIn2.Point = new Point(365, 0);
                    //LinkedList link2 = new LinkedList();
                    //C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, d);
                    //btnCheckIn2.Enabled = false;
                    //comboBox2.Enabled = false;
                    //lbDrop2.Text = d.Name;
                    //removeDropFromComboBoxs(d.Number);

                    airport.DevideBetween2Checks(d, checkInNum, 2);

                    CheckIn1Timer.Tag = d;
                    CheckIn1Timer.Interval = 1;
                    CheckIn1Timer.Start();

                    CheckIn2Timer.Tag = d;
                    CheckIn2Timer.Interval = 1;
                    CheckIn2Timer.Start();


                }
            }
            else if (btnCheckIn3.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn3 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    x = true;
                    d.UsedBy = 3;

                    CreateCheckIn3(d);

                    //CheckIn checkIn3 = new CheckIn(d, "checkIn3", 3);
                    //airport.addCheckin(checkIn3);

                    //Conveyor conveyor5 = new Conveyor(d, "conv5");
                    //Conveyor conveyor6 = new Conveyor(d, "conv6");
                    //checkIn3.Point = new Point(525, 0);
                    //LinkedList link3 = new LinkedList();
                    //C3 = new CreateLinkList(link3, checkIn3, conveyor5, conveyor6, mpa, d);
                    //btnCheckIn3.Enabled = false;
                    //comboBox3.Enabled = false;
                    //lbDrop3.Text = d.Name;


                    airport.DevideBetween2Checks(d, checkInNum, 3);
                    CheckIn3Timer.Tag = d;
                    CheckIn3Timer.Interval = 1;
                    CheckIn3Timer.Start();
                }
            }
            else if (btnCheckIn4.Enabled == true)
            {
                //use checkin2 as well
                if (MessageBox.Show("Make use of checkIn4 for " + d.Name, "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    x = true;
                    d.UsedBy = 4;
                    CreateCheckIn4(d);

                    //CheckIn checkIn4 = new CheckIn(d, "checkIn4", 4);
                    //airport.addCheckin(checkIn4);
                    //Conveyor conveyor7 = new Conveyor(d, "conv7");
                    //Conveyor conveyor8 = new Conveyor(d, "conv8");
                    //checkIn4.Point = new Point(685, 0);
                    //LinkedList link4 = new LinkedList();
                    //C4 = new CreateLinkList(link4, checkIn4, conveyor7, conveyor8, mpa, d);

                    //btnCheckIn4.Enabled = false;
                    //comboBox4.Enabled = false;
                    //lbDrop4.Text = d.Name;
                


                    airport.DevideBetween2Checks(d, checkInNum, 4);
                    CheckIn4Timer.Tag = d;
                    CheckIn4Timer.Interval = 1;
                    CheckIn4Timer.Start();
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
            CreateLinkList C1 = new CreateLinkList(link1, checkIn1, conveyor1, conveyor2, mpa, d);
            airport.addLinkList(C1);
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
            CreateLinkList C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, d);
            airport.addLinkList(C2);
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
            CreateLinkList C3 = new CreateLinkList(link3, checkIn3, conveyor5, conveyor6, mpa, d);
            airport.addLinkList(C3);
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
            CreateLinkList C4 = new CreateLinkList(link4, checkIn4, conveyor7, conveyor8, mpa, d);
            airport.addLinkList(C4);
            btnCheckIn4.Enabled = false;
            comboBox4.Enabled = false;
            lbDrop4.Text = d.Name;
        }

        public void startCheckIn1(DropOff dr)
        {
            UpdateComboBoxes();
            CreateCheckIn1(dr);
            airport.AssignTimerToBags(1, dr);
            //CheckIn checkIn1;
            //checkIn1 = new CheckIn(dr, "checkIn1", 1);
            //airport.addCheckin(checkIn1);
            //Conveyor conveyor1 = new Conveyor(dr, "conv1");
            //Conveyor conveyor2 = new Conveyor(dr, "conv2");
            //checkIn1.Point = new Point(205, 0);
            //LinkedList link1 = new LinkedList();
            //C1 = new CreateLinkList(link1, checkIn1, conveyor1, conveyor2, mpa, dr);
            //btnStart.Enabled = false;
            //comboBox1.Enabled = false;
            //lbDrop1.Text = dr.Name;

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
            UpdateComboBoxes();
            CreateCheckIn3(dr);
            airport.AssignTimerToBags(3, dr);
            //CheckIn checkIn3 = new CheckIn(dr, "checkIn3", 3);
            //airport.addCheckin(checkIn3);

            //Conveyor conveyor5 = new Conveyor(dr, "conv5");
            //Conveyor conveyor6 = new Conveyor(dr, "conv6");
            //checkIn3.Point = new Point(525, 0);
            //LinkedList link3 = new LinkedList();
            //C3 = new CreateLinkList(link3, checkIn3, conveyor5, conveyor6, mpa, dr);
            //btnCheckIn3.Enabled = false;
            //comboBox3.Enabled = false;
            //lbDrop3.Text = dr.Name;

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
            UpdateComboBoxes();
            CreateCheckIn2(dr);
            airport.AssignTimerToBags(2,dr);
            //CheckIn checkIn2;
            //checkIn2 = new CheckIn(dr, "checkIn2", 2);
            //airport.addCheckin(checkIn2);
            //Conveyor conveyor3 = new Conveyor(dr, "conv3");
            //Conveyor conveyor4 = new Conveyor(dr, "conv4");
            //checkIn2.Point = new Point(365, 0);
            //LinkedList link2 = new LinkedList();
            //C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, dr);
            //btnCheckIn2.Enabled = false;
            //comboBox2.Enabled = false;
            //lbDrop2.Text = dr.Name;

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
            UpdateComboBoxes();
            CreateCheckIn4(dr);
            airport.AssignTimerToBags(4, dr);
            //CheckIn checkIn4 = new CheckIn(dr, "checkIn4", 4);
            //airport.addCheckin(checkIn4);
            //Conveyor conveyor7 = new Conveyor(dr, "conv7");
            //Conveyor conveyor8 = new Conveyor(dr, "conv8");
            //checkIn4.Point = new Point(685, 0);
            //LinkedList link4 = new LinkedList();
            //C4 = new CreateLinkList(link4, checkIn4, conveyor7, conveyor8, mpa, dr);
            //btnCheckIn4.Enabled = false;
            //comboBox4.Enabled = false;
            //lbDrop4.Text = dr.Name;

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

        public void UpdateComboBoxes()
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            foreach(DropOff a in airport.DropOffs)
            {
                comboBox1.Items.Add(a.Name);
                comboBox2.Items.Add(a.Name);
                comboBox3.Items.Add(a.Name);
                comboBox4.Items.Add(a.Name);
            }
          
            

            
           

            
            
        }

        private void CheckIn1_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn1Timer.Tag;
            CheckIn ch = airport.GetCheckInById(1);
            CreateLinkList C = airport.getCLinkList(1);
            int timer = 0;

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
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false )
                    {
                        

                        bagMove((PictureBox)this.Controls[i]);

                        
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            if (airport.getBagByDropOff(d)[j].TimerId == 2 || airport.getBagByDropOff(d)[j].TimerId == 0)
                            {
                                C = airport.getCLinkList(2);
                                timer = 2;
                            }
                            else if (airport.getBagByDropOff(d)[j].TimerId == 1)
                            {
                                C = airport.getCLinkList(1);
                                timer = 1;

                            }
                            else if (airport.getBagByDropOff(d)[j].TimerId == 3)
                            {
                                C = airport.getCLinkList(3);
                                timer = 3;
                            }
                            else if (airport.getBagByDropOff(d)[j].TimerId == 4)
                            {
                                C = airport.getCLinkList(4);
                                timer = 4;
                            }

                            LinkedList link1 = C.LinkList;
                            link1.PassBaggage(airport.getBagByDropOff(d)[j]);
                            d.BagsArrived.Add(airport.getBagByDropOff(d)[j]);
                            lbbags.Text = d.BagsArrived.Count().ToString();
                            //lbbags.Text = link1.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                            airport.getBagByDropOff(d)[j].ReachedDrop = true;
                            ((PictureBox)this.Controls[i]).Visible = false;
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

        private void btnCheckIn2_Click(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            DropOff drop = GetDropSelected(2);
            if (drop.UsedBy != 0)
            {
                startCheckIn2(drop);
                airport.DevideBetween2Checks(drop, 2, drop.UsedBy);
                drop.UsedBy = 2;
                comboBox2.Items.RemoveAt(drop.Number);
            }
            else
            {
                startCheckIn2(drop);
                drop.UsedBy = 2;           
                CheckIn2Timer.Interval = 1;
                CheckIn2Timer.Tag = drop;
                CheckIn2Timer.Start();
            }

            
            btnCheckIn2.Enabled = false;
        }
        private void CheckIn2_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn2Timer.Tag;
            CheckIn ch = airport.GetCheckInById(2);
            CreateLinkList C = airport.getCLinkList(2);
            int timer = 0;

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
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false )
                    {
                        
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                if (airport.getBagByDropOff(d)[j].TimerId == 2 || airport.getBagByDropOff(d)[j].TimerId == 0)
                                {
                                    C = airport.getCLinkList(2);
                                    timer = 2;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 1)
                                {
                                    C = airport.getCLinkList(1);
                                    timer = 1;
                                    
                                }else if (airport.getBagByDropOff(d)[j].TimerId == 3 )
                                {
                                    C = airport.getCLinkList(3);
                                    timer = 3;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 4)
                                {
                                    C = airport.getCLinkList(4);
                                    timer = 4;
                                }
                                LinkedList link = C.LinkList;
                                
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                d.BagsArrived.Add(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = d.BagsArrived.Count().ToString();
                                //lbbags.Text = link.getAllBags().Count().ToString();
                                airport.getBagByDropOff(d)[j].IsOnConveyer = false;
                                airport.getBagByDropOff(d)[j].ReachedDrop = true;
                                ((PictureBox)this.Controls[i]).Visible = false;
                            }
                        }
                    }
                }
            }
            //delay 
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
            CheckIn3Timer.Interval = 50;
            CheckIn4Timer.Interval = 50;
        }

        //returns the speed of the bags into the predifined speed
        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn1Timer.Interval = 1;
            CheckIn2Timer.Interval = 1;
            CheckIn3Timer.Interval = 1;
            CheckIn4Timer.Interval = 1;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myBlackPen = new Pen(Color.Gray); // Pen: Draws the border around a shape
            Pen myWhitePen = new Pen(Color.White);

            SolidBrush myBlackBrush = new SolidBrush(Color.Black); // Brush: Paints the interior of a shape
            SolidBrush myBlueBrush = new SolidBrush(Color.DarkTurquoise);// Brush: Paints the interior of a shape
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

                if (btnCheckIn3.Enabled == false)
                {
                    CheckIn3Timer.Interval = 1;
                    CheckIn3Timer.Start();
                }
                if (btnCheckIn4.Enabled == false)
                {
                    CheckIn4Timer.Interval = 1;
                    CheckIn4Timer.Start();
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

                if (btnCheckIn3.Enabled == false)
                {
                    CheckIn3Timer.Enabled = true;
                    CheckIn3Timer.Stop();
                }

                if (btnCheckIn4.Enabled == false)
                {
                    CheckIn4Timer.Enabled = true;
                    CheckIn4Timer.Stop();
                }

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mpa = new MainProcessArea("mpa1");
            btnStart.Enabled = false;
            DropOff drop = GetDropSelected(1);
            drop.UsedBy = 1;
            startCheckIn1(drop);
            btnCheckIn2.Enabled = true;
            btnCheckIn3.Enabled = true;
            btnBreak.Enabled = true;
            btnCheckIn4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

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

        private void removeDropFromComboBoxs(int dropNum)
        {
            int num = dropNum - 1;
            List<ComboBox> combos = new List<ComboBox>()
            {
                comboBox1,
                comboBox2,
                comboBox3,
                comboBox4
            };

            foreach (ComboBox c in combos)
                {
                    c.Items.RemoveAt(num);
                }
            
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
            if (cb.Text == "drop1")
            {
                d = airport.getDrop("drop1");
            }
            else if (cb.Text == "drop2")
            {
                d = airport.getDrop("drop2");
            }
            else if (cb.Text == "drop3")
            {
                d = airport.getDrop("drop3");
            }
            return d;
        }

        private void CheckIn3Timer_Tick(object sender, EventArgs e)
        {
            DropOff d = (DropOff)CheckIn3Timer.Tag;
            CheckIn ch = airport.GetCheckInById(3);
            CreateLinkList C = airport.getCLinkList(3);
            int timer = 0;

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
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false && (airport.getBagByDropOff(d)[j].TimerId == 3 || airport.getBagByDropOff(d)[j].TimerId == 0))
                    {
                        
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                if (airport.getBagByDropOff(d)[j].TimerId == 2 || airport.getBagByDropOff(d)[j].TimerId == 0)
                                {
                                    C = airport.getCLinkList(2);
                                    timer = 2;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 1)
                                {
                                    C = airport.getCLinkList(1);
                                    timer = 1;

                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 3)
                                {
                                    C = airport.getCLinkList(3);
                                    timer = 3;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 4)
                                {
                                    C = airport.getCLinkList(4);
                                    timer = 4;
                                }

                                LinkedList link = C.LinkList;
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                d.BagsArrived.Add(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = d.BagsArrived.Count().ToString();
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
            CreateLinkList C = airport.getCLinkList(4);
            int timer = 0;

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
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d)[j].BaggageNumber}" && airport.getBagByDropOff(d)[j].Suspicious == false && (airport.getBagByDropOff(d)[j].TimerId == 4 || airport.getBagByDropOff(d)[j].TimerId == 0))
                    {
                        
                        {
                            bagMove((PictureBox)this.Controls[i]);
                            if (((PictureBox)this.Controls[i]).Location.Y == 546)
                            {
                                if (airport.getBagByDropOff(d)[j].TimerId == 2 || airport.getBagByDropOff(d)[j].TimerId == 0)
                                {
                                    C = airport.getCLinkList(2);
                                    timer = 2;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 1)
                                {
                                    C = airport.getCLinkList(1);
                                    timer = 1;

                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 3)
                                {
                                    C = airport.getCLinkList(3);
                                    timer = 3;
                                }
                                else if (airport.getBagByDropOff(d)[j].TimerId == 4)
                                {
                                    C = airport.getCLinkList(4);
                                    timer = 4;
                                }

                                LinkedList link = C.LinkList;
                                link.PassBaggage(airport.getBagByDropOff(d)[j]);
                                d.BagsArrived.Add(airport.getBagByDropOff(d)[j]);
                                lbbags.Text = d.BagsArrived.Count().ToString();
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

        private void btnCheckIn3_Click_1(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            DropOff drop = GetDropSelected(3);
            if (drop.UsedBy != 0)
            {
                startCheckIn3(drop);
                airport.DevideBetween2Checks(drop, 3, drop.UsedBy);
                drop.UsedBy = 3;
                //comboBox3.Items.RemoveAt(drop.Number);
            }
            else
            {
                startCheckIn3(drop);
                drop.UsedBy = 3;
                CheckIn3Timer.Interval = 1;
                CheckIn3Timer.Tag = drop;
                CheckIn3Timer.Start();
            }

            
            
            btnCheckIn3.Enabled = false;
        }


        private void btnCheckIn4_Click(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            DropOff drop = GetDropSelected(4);
            if (drop.UsedBy != 0)
            {
                startCheckIn4(drop);
                airport.DevideBetween2Checks(drop, 4, drop.UsedBy);
                drop.UsedBy = 4;
                //comboBox4.Items.RemoveAt(drop.Number);
            }
            else
            {
                startCheckIn4(drop);
                drop.UsedBy = 4;
                CheckIn4Timer.Interval = 1;
                CheckIn4Timer.Tag = drop;
                CheckIn4Timer.Start();
            }

            btnCheckIn4.Enabled = false;
        }

        public void Export()
        {
            Statistics statistics = new Statistics();
            statistics.DropOff1Bags = lbBags1.Text;
            statistics.DropOff1CheckIns = lbCheckIn1.Text;
            statistics.DropOff1Passengers = lbPassenger1.Text;
            statistics.DropOff2Bags = lbBags2.Text;
            statistics.DropOff2CheckIns = lbCheckIn2.Text;
            statistics.DropOff2Passengers = lbPassenger2.Text;
            statistics.DropOff3Bags = lbBags3.Text;
            statistics.DropOff3CheckIns = lbCheckIn3.Text;
            statistics.DropOff3Passengers = lbPassenger3.Text;


            string path = @"D:\Example.txt";

            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine("Drop off 1:");
                tw.WriteLine("Bags {0}", statistics.DropOff1Bags);
                tw.WriteLine("Check Ins started {0}", statistics.DropOff1CheckIns);
                tw.WriteLine("Passengers for this drop off {0}", statistics.DropOff1Passengers);

                tw.WriteLine("Drop off 2:");
                tw.WriteLine("Bags {0}", statistics.DropOff2Bags);
                tw.WriteLine("Check Ins started {0}", statistics.DropOff2CheckIns);
                tw.WriteLine("Passengers for this drop off {0}", statistics.DropOff2Passengers);

                tw.WriteLine("Drop off 3:");
                tw.WriteLine("Bags {0}", statistics.DropOff3Bags);
                tw.WriteLine("Check Ins started {0}", statistics.DropOff3CheckIns);
                tw.WriteLine("Passengers for this drop off {0}", statistics.DropOff3Passengers);

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void AddBaggages()
        {

            //Airport airportExport = new Airport();
            string path = @"D:\Example.binary";

            IFormatter bf = new BinaryFormatter();
            Stream fsout = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, airport.GenerateBaggages());
                    
                    MessageBox.Show("here");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void DeserializeBaggages()
        {
            
            string path = @"D:\Example.binary";
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream(path, FileMode.Open);
            try
            {
                using(fsout)
                {
                    if(fsout.Length > 0)
                    {

                        List<Baggage> baggages = bf.Deserialize(fsout) as List<Baggage>;
                        //List<Passenger> passengers = bf.Deserialize(fsout) as List<Passenger>;

                       

                        foreach(Baggage b in baggages)
                        {
                            airport.AddBag(b);
                        }
                        foreach(Baggage a in airport.GetAllBags())
                        {
                            Console.WriteLine(a.BaggageId);
                            Console.WriteLine(a.DropOffGate.Name);
                            
                        }

                        foreach(DropOff d in airport.DropOffs)
                        {
                            Debug.WriteLine(airport.getBagByDropOff(d).Count);
                            
                        }
                        //airport.AddBag(baggage as Baggage);
                        MessageBox.Show("done");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            fsout.Close();

           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddBaggages();
        }
        //public CreateLinkList GetListUsingBagTimer(int timer)
        //{
        //    CreateLinkList c = null;


        //    return c;
        //}



        private void Button5_Click(object sender, EventArgs e)
        {
            DeserializeBaggages();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label15.Text = Convert.ToString(airport.GetAllBags().Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
