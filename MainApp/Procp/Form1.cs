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
        public bool stuck = false;//if true then red bag stops moving
        Airport airport;
        MainProcessArea mpa;
        DropOff d1;
        LinkedList link1;

        int count = 0;
        int currentBag = 0;
        int nextDrop= 0;
        int CounterForDropOff1 = 0;

        public Form1()
        {
            InitializeComponent();
            airport = new Airport();
            mpa = new MainProcessArea();
            link1 = new LinkedList();
            d1 = airport.getDrop("drop1");
            startDropOff1();
            
        }
        public int bagMove(PictureBox p)
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
            return p.Bottom;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Drop1.Interval = 1;//red square timer
            Drop1.Start();
            timerBag4.Interval = 1;//orange square timer(from check in 2)
            timer2.Interval = 14100;//timer for bag stuck randomization
            timer2.Start();
            switchTimer.Interval = 11200;//timer for SECURITY CHECK randomization
            switchTimer.Start();
            pb_luggage4.Visible = false;//shows the first bag of check in 2
            pb_luggage5.Visible = false;//shows the second bag of check in 2
            pb_luggage6.Visible = false;//shows the third bag of check in 2
        }

        public void startDropOff1()
        {
            //For dropOff1
            CheckIn checkIn1 = new CheckIn(d1, "checkIn1");
            airport.addCheckin(checkIn1);
            Conveyor conveyor1 = new Conveyor(d1, "conv1");
            Conveyor conveyor2 = new Conveyor(d1, "conv2");

            CreateLinkList C1 = new CreateLinkList(link1,checkIn1,conveyor1,conveyor2,mpa,d1);
        }
  

        
        private void sendBag()
        {
            if (currentBag < airport.getBagByDropOff(d1).Count)
            {
                Baggage b = airport.getBagByDropOff(d1)[currentBag];

                currentBag++;

                if (!b.IsOnConveyer)
                {
                    PictureBox p = new PictureBox
                    {
                        Name = $"pictureBox{b.BaggageNumber}",
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(50, 55),
                        Location = new Point(200, 0),
                        BackColor = Color.Brown

                    };
                    this.Controls.Add(p);
                    b.IsOnConveyer = true;
                }
            }
        }

        //the red square moves to the drop off in a predefined path
        private void Drop1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                for (int j = 0; j < currentBag; j++)
                {
                    if (this.Controls[i].Name == $"pictureBox{airport.getBagByDropOff(d1)[j].BaggageNumber}")
                    {
                        bagMove((PictureBox)this.Controls[i]);
                        if (((PictureBox)this.Controls[i]).Location.Y == 520)
                        {
                            link1.PassBaggage(airport.getBagByDropOff(d1)[j]);
                            CounterForDropOff1++;
                            lbBagsCounterD1.Text = link1.getAllBags().Count().ToString();
                            airport.getBagByDropOff(d1)[j].IsOnConveyer = false;
                        }
                        
                    }
                }
                
            }
            
            int[] arrays = { 50, 100, 400 };
            if (count % arrays[nextDrop] == 0)
            {
                sendBag();
                Random random = new Random();
                nextDrop = random.Next(0, 2);
            }
            count++;
        }  

        //checkIn2
        private void timerBag4_Tick(object sender, EventArgs e)
        {
            //the orange square (from check in 2) moves to the drop off in a predefined path
            if (pb_luggage4.Top < 60)
            {
                pb_luggage4.Top += 2;
            }
            else if (pb_luggage4.Top < 390 && pb_luggage4.Left > 300)
            {
                pb_luggage4.Left -= 2;

            }
            else
            {
                if (pb_luggage4.Top > 390 && pb_luggage4.Left < 515)
                {
                    pb_luggage4.Left += 2;
                }
                else
                {
                    pb_luggage4.Top += 2;
                }
            }
            //the gray square (from check in 2) moves to the drop off in a predefined path
            if (pb_luggage5.Top < 60 && pb_luggage4.Top > 59)
            {
                pb_luggage5.Top += 2;
            }
            else if (pb_luggage5.Top < 390 && pb_luggage5.Left > 300 && pb_luggage4.Top > 59)
            {
                pb_luggage5.Left -= 2;
            }
            else
            {
                if (pb_luggage5.Top > 390 && pb_luggage5.Left < 515 && pb_luggage4.Top > 59)
                {
                    pb_luggage5.Left += 2;

                }
                else if (pb_luggage4.Top > 59 || pb_luggage6.Top > 300)
                {
                    pb_luggage5.Top += 2;
                }
            }
            //the pink square (from check in 2) moves to the drop off in a predefined path
            if (pb_luggage6.Top < 60 && pb_luggage5.Top > 59)
            {
                pb_luggage6.Top += 2;
            }
            else if (pb_luggage6.Top < 390 && pb_luggage6.Left > 300 && pb_luggage5.Top > 59)
            {
                pb_luggage6.Left -= 2;
            }
            else
            {
                if (pb_luggage6.Top > 390 && pb_luggage6.Left < 515 && pb_luggage5.Top > 59)
                {
                    pb_luggage6.Left += 2;

                }
                else if (pb_luggage6.Top > 59)
                {
                    pb_luggage6.Top += 2;
                }
            }

        }


        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage_LocationChanged(object sender, EventArgs e)
        {

            //if (pb_luggage.Top >= this.Width)
            //{
            //    pb_luggage.Top = 0 - pb_luggage.Height;
            //    pb_luggage.Left = 200;
            //}

        }

        //triggers the bag stuck button, which stops the conveyer
        private void timer2_Tick(object sender, EventArgs e)
        {
            //stuck = true;
            //blink.Start();
        }

        //stops the blinking of the bag stuck button and starts the conveyer
        private void bagStuck_Click(object sender, EventArgs e)
        {
            //timer2.Stop();
            //stuck = false;

            //blink.Stop();
            //bagStuck.BackColor = Color.Blue;
            //timer2.Start();
        }

        //changes the color of the bag stuck button 
        private void blink_Tick(object sender, EventArgs e)
        {
            //if (bagStuck.BackColor == Color.Black)
            //{
            //    bagStuck.BackColor = Color.Red;
            //}
            //else
            //{
            //    bagStuck.BackColor = Color.Black;
            //}
        }


        //triggers the security check button, which sends the bag at the top left corner
        private void switchTimer_Tick(object sender, EventArgs e)
        {

            //Drop1.Stop();
            //blink2.Start();
            //pb_luggage.Top = 0;
            //pb_luggage.Left = 0;

        }

        //when you click on the security button it sends the seized bag back to the conveyer
        private void buttonSec_Click(object sender, EventArgs e)
        {

            //switchTimer.Stop();
            //pb_luggage.Visible = true;
            //Drop1.Start();
            //blink2.Stop();
            //buttonSec.BackColor = Color.Blue;
            //switchTimer.Start();


        }

        //changes the color of the security check button
        private void blink2_Tick(object sender, EventArgs e)
        {

            //if (buttonSec.BackColor == Color.Black)
            //{
            //    buttonSec.BackColor = Color.Red;
            //}
            //else
            //{
            //    buttonSec.BackColor = Color.Black;
            //}

        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage2_LocationChanged(object sender, EventArgs e)
        {
            //if (pb_luggage2.Top >= this.Width)
            //{
            //    pb_luggage2.Top = 0 - pb_luggage2.Height;
            //    pb_luggage2.Left = 200;
            //}
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
            //if (pictureBox1.Top >= this.Width)
            //{
            //    pictureBox1.Top = 0 - pictureBox1.Height;
            //    pictureBox1.Left = 200;
            //}
        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage5_LocationChanged(object sender, EventArgs e)
        {
            //if (pb_luggage5.Top >= this.Width)
            //{
            //    pb_luggage5.Top = 0 - pb_luggage5.Height;
            //    pb_luggage5.Left = 515;
            //}
        }


        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage6_LocationChanged(object sender, EventArgs e)
        {
            //if (pb_luggage6.Top >= this.Width)
            //{
            //    pb_luggage6.Top = 0 - pb_luggage6.Height;
            //    pb_luggage6.Left = 515;
            //}
        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage4_LocationChanged(object sender, EventArgs e)
        {
            //if (pb_luggage4.Top >= this.Width)
            //{
            //    pb_luggage4.Top = 0 - pb_luggage4.Height;
            //    pb_luggage4.Left = 515;
            //}
        }

        //starts the 2nd check in 
        private void button3_Click(object sender, EventArgs e)
        {
            pb_luggage4.Visible = true;
            pb_luggage5.Visible = true;
            pb_luggage6.Visible = true;
            timerBag4.Start();
        }

        //closes the 2nd check in
        private void CloseCheckIn_Click(object sender, EventArgs e)
        {
            timerBag4.Stop();
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

        private void pb_luggage5_Click(object sender, EventArgs e)
        {

        }
    }
}
