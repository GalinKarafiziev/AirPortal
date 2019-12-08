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
        LinkedList link1;
        CreateLinkList C2;

        //for dropOff1
        int countD1 = 0;
        int currentBagD1 = 0;
        int nextDropD1 = 0;
        Point PointD1 = new Point(200, 0);

        public Form1()
        {
            InitializeComponent();
            airport = new Airport();
            mpa = new MainProcessArea();
            link1 = new LinkedList();
            d1 = airport.getDrop("drop1");
            startDropOff1();
        }

        public void bagMoveD1(PictureBox p)
        {
            if (p.Top < 60)
            {
                p.Top += 2;

            }
            else if (p.Top < 390 && p.Left < 200)
            {
                p.Left += 2;

            }
            else
            {
                if (p.Top > 390 && p.Left > 10)
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
            Drop1.Interval = 1;
            Drop1.Start();
        }

        public void startDropOff1()
        {
            //For dropOff1
            CheckIn checkIn1 = new CheckIn(d1, "checkIn1");
            airport.addCheckin(checkIn1);
            Conveyor conveyor1 = new Conveyor(d1, "conv1");
            Conveyor conveyor2 = new Conveyor(d1, "conv2");

            CreateLinkList C1 = new CreateLinkList(link1, checkIn1, conveyor1, conveyor2, mpa, d1);
        }

        public void startDropOff2()
        {
            //For dropOff2
            CheckIn checkIn2 = new CheckIn(airport.getDrop("drop2"), "checkIn2");
            airport.addCheckin(checkIn2);
            Conveyor conveyor3 = new Conveyor(d1, "conv3");
            Conveyor conveyor4 = new Conveyor(d1, "conv4");
            DropOff d2 = airport.getDrop("drop2");
            d2.Count = 0;
            d2.CurrentBag = 0;
            d2.Point = new Point(520, 0);
            LinkedList link2 = new LinkedList();

            C2 = new CreateLinkList(link2, checkIn2, conveyor3, conveyor4, mpa, d2);
        }

        public void adder(DropOff DF)
        {
            DropOff d2 = airport.getDrop("drop2");
            if (DF == d1)
            {
                currentBagD1++;
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
                return currentBagD1;
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

                adder(d);

                if (!b.IsOnConveyer)
                {
                    PictureBox p = new PictureBox
                    {
                        Name = $"pictureBox{b.BaggageNumber}",
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(50, 55),
                        Location = loc,
                        BackColor = Color.Black

                    };
                    this.Controls.Add(p);
                    b.IsOnConveyer = true;
                }
            }
        }
        
      
        private void Drop1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                for (int j = 0; j < currentBagD1; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d1)[j].BaggageNumber}")
                    {
                        bagMoveD1((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link1.PassBaggage(airport.getBagByDropOff(d1)[j]);
                            lbBagsCounterD1.Text = link1.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d1)[j].IsOnConveyer = false;
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }
                }
            }
            int[] arrays = { 100, 150, 180 };
            if (countD1 % arrays[nextDropD1] == 0)
            {
                sendBag(d1, PointD1);
                Random random = new Random();
                nextDropD1 = random.Next(0, 2);
            }
            countD1++;


        }

        //checkIn2
        private void btnCheckIn2_Click(object sender, EventArgs e)
        {
            startDropOff2();
            Drop2.Interval = 1;
            Drop2.Start();
        }

        public void bagMoveD2(PictureBox p)
        {
            if (p.Top < 60)
            {
                p.Top += 2;
            }
            else if (p.Top < 390 && p.Left > 300)
            {
                p.Left -= 2;

            }
            else
            {
                if (p.Top > 390 && p.Left < 515)
                {
                    p.Left += 2;
                }
                else
                {
                    p.Top += 2;
                }
            }
        }

        
        private void Drop2_Tick(object sender, EventArgs e)
        {
            DropOff d2 = airport.getDrop("drop2");
            for (int i = 0; i < this.Controls.Count; i++)
            {
                for (int j = 0; j < d2.CurrentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d2)[j].BaggageNumber}")
                    {
                        LinkedList link2 = C2.LinkList;
                        bagMoveD2((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 546)
                        {
                            link2.PassBaggage(airport.getBagByDropOff(d2)[j]);
                            lbBagsCounterD2.Text = link2.getAllBags().Count().ToString();
                            ((PictureBox)this.Controls[i]).Visible = false;
                        }

                    }
                }
            }
            //delay for dropOff2
            int[] arrays = { 100, 150, 180 };
            if (d2.Count % arrays[nextDropD1] == 0)
            {
                sendBag(d2, d2.Point);
                Random random = new Random();
                nextDropD1 = random.Next(0, 2);
            }
            d2.Count++;
        }

        //Slows down the bags in a specific speed
        private void button2_Click(object sender, EventArgs e)
        {
            Drop1.Interval = 50;
        }

        //returns the speed of the bags into the predifined speed
        private void button1_Click(object sender, EventArgs e)
        {
            Drop1.Interval = 1;
        }
 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myBlackPen = new Pen(Color.Black); // Pen: Draws the border around a shape
            Pen myWhitePen = new Pen(Color.White);
            SolidBrush myBlackBrush = new SolidBrush(Color.Black); // Brush: Paints the interior of a shape 
            SolidBrush myWhiteBrush = new SolidBrush(Color.White);
            Rectangle[] rectangles =
            {
                new Rectangle(0, 0, 90, 130), //Security down1
                new Rectangle(90, 50, 95, 80), //Security left1 
                new Rectangle(185, 0, 90, 130), //checkin1 down1
                new Rectangle(91, 380, 94, 75), //checkin1 left1
                new Rectangle(1, 380, 90, 160), //checkin1 down2

                new Rectangle(500, 0, 90, 130), //checkin2 down1 
                new Rectangle(290, 50, 210, 80), //checkin2 left1  
                new Rectangle(365, 380, 135, 75), //checkin2 right1 
                new Rectangle(500, 380, 90, 160), //chechkin2 down2
                
                new Rectangle(185, 130, 180, 325), //down checkin1,2
            };
            e.Graphics.DrawRectangles(myBlackPen, rectangles); //Draw rectangles

            g.DrawLine(myWhitePen, 90, 51, 90, 129); //Line that hides black line on Security down1 + Security left1
            g.DrawLine(myWhitePen, 185, 51, 185, 129); //Line that hides black line on left1 Security + down1 checkin1
            g.DrawLine(myWhitePen, 186, 130, 274, 130); //Line that hides black line on down1 checkin1 + down checkin1,2
            g.DrawLine(myWhitePen, 185, 381, 185, 454); //Line that hides black line on down checkin1,2 + checkin1 left1
            g.DrawLine(myWhitePen, 91, 381, 91, 454); //Line that hides black line on checkin1 left1 + checkin1 down2

            g.DrawLine(myWhitePen, 500, 51, 500, 129); //Line that hides black line on checkin2 down1 + checkin2 left1
            g.DrawLine(myWhitePen, 291, 130, 364, 130); //Line that hides black line on checkin2 left1 + down checkin1,2
            g.DrawLine(myWhitePen, 365, 381, 365, 454); //Line that hides black line on down checkin1,2 + checkin2 right1
            g.DrawLine(myWhitePen, 500, 381, 500, 454); //Line that hides black line on checkin2 right1 + chechkin2 down2

            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 15);
            //g.DrawString("Check-in", font, myBlackBrush, new PointF(62, 24));
            //g.DrawString("Security", font, myBlackBrush, new PointF(205, 220));
            //g.DrawString("Drop-off", font, myBlackBrush, new PointF(345, 414));
        }

        private void CloseCheckIn_Click(object sender, EventArgs e)
        {

        }
    }
}
