using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procp
{
    public partial class Form1 : Form
    {
        public bool stuck = false;//if true then red bag stops moving

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Game.Interval = 1;//red square timer
            Timer_Game.Start();
            secondBag.Interval = 1;//green square timer
            thirdBag.Interval = 1;//blue square timer 
            timerBag4.Interval = 1;//orange square timer(from check in 2)
            timerBag5.Interval = 1;//gray square timer(from check in 2)
            timerBag6.Interval = 1;//pink square timer(from check in 2)
            timer2.Interval = 14100;//timer for bag stuck randomization
            timer2.Start();

           
            securityCheck.Interval = 1000;//timer for the time for second bag to start NOT FOR SECURITY!!(Sorry for that)
            securityCheck.Start();
            switchTimer.Interval = 11200;//timer for SECURITY CHECK randomization
            switchTimer.Start();
            thirdBagSwitch.Interval = 2000;//timer for the time for third bag to start
            thirdBagSwitch.Start();
            bag5Switch.Interval = 1000;//timer for the second bag OF CHECK IN 2 to start
            
            bag6Switch.Interval = 2000;//timer for the third bag OF CHECK IN 2 to start
            pb_luggage4.Visible = false;//shows the first bag of check in 2
            pb_luggage5.Visible = false;//shows the second bag of check in 2
            pb_luggage6.Visible = false;//shows the third bag of check in 2
        }
        
        //the red square moves to the drop off in a predefined path
        private void Timer_Game_Tick(object sender, EventArgs e)
        {
            if (stuck == true)
            {
                pictureBox1.Top += 0;// when true the red square stops moving
            }
            else
            {
                if (pb_luggage.Top < 60)
                {
                    pb_luggage.Top += 2;
                }
                else if (pb_luggage.Top < 390 && pb_luggage.Left < 200)
                {
                    pb_luggage.Left += 2;
                }
                else
                {
                    if (pb_luggage.Top > 390 && pb_luggage.Left > 10)
                    {
                        pb_luggage.Left -= 2;
                    }
                    else
                    {
                        pb_luggage.Top += 2;
                    }
                }
            }
            
        }
        
         //the green square moves to the drop off in a predefined path
        private void secondBag_Tick(object sender, EventArgs e)
        {

            if (pb_luggage2.Top < 60)
            {
                pb_luggage2.Top += 2;
            }
            else if (pb_luggage2.Top < 390 && pb_luggage2.Left < 200)
            {
                pb_luggage2.Left += 2;
            }
            else {
                if (pb_luggage2.Top > 390 && pb_luggage2.Left > 10)
                {
                    pb_luggage2.Left -= 2;
                }
                else
                {
                    pb_luggage2.Top += 2;
                }
            }
        }
        
         //the blue square moves to the drop off in a predefined path
        private void thirdBag_Tick(object sender, EventArgs e)
        {
            if (stuck == true)
            {
                pictureBox1.Top += 0;
            }
            else
            {
                if (pictureBox1.Top < 60)
                {
                    pictureBox1.Top += 2;
                }
                else if (pictureBox1.Top < 390 && pictureBox1.Left < 200)
                {
                    pictureBox1.Left += 2;
                }
                else
                {
                    if (pictureBox1.Top > 390 && pictureBox1.Left > 10)
                    {
                        pictureBox1.Left -= 2;
                    }
                    else
                    {
                        pictureBox1.Top += 2;
                    }
                }
            }
        }
        
         //starts the blue square
           private void thirdBagSwitch_Tick(object sender, EventArgs e)
        {
            thirdBag.Start();
        }
        
        //the orange square (from check in 2) moves to the drop off in a predefined path
        private void timerBag4_Tick(object sender, EventArgs e)
        {
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
        }
        
         //the gray square (from check in 2) moves to the drop off in a predefined path
           private void timerBag5_Tick(object sender, EventArgs e)
        {
            if (pb_luggage5.Top < 60)
            {
                pb_luggage5.Top += 2;
            }
            else if (pb_luggage5.Top < 390 && pb_luggage5.Left > 300)
            {
                pb_luggage5.Left -= 2;
            }
            else
            {
                if (pb_luggage5.Top > 390 && pb_luggage5.Left < 515)
                {
                    pb_luggage5.Left += 2;
                }
                else
                {
                    pb_luggage5.Top += 2;
                }
            }
        }
        
        //starts the gray square
        private void bag5Switch_Tick(object sender, EventArgs e)
        {
            
            timerBag5.Start();
        }

       
        //the pink square (from check in 2) moves to the drop off in a predefined path
        private void timerBag6_Tick(object sender, EventArgs e)
        {
            if (pb_luggage6.Top < 60)
            {
                pb_luggage6.Top += 2;
            }
            else if (pb_luggage6.Top < 390 && pb_luggage6.Left > 300)
            {
                pb_luggage6.Left -= 2;
            }
            else
            {
                if (pb_luggage6.Top > 390 && pb_luggage6.Left < 515)
                {
                    pb_luggage6.Left += 2;
                }
                else
                {
                    pb_luggage6.Top += 2;
                }
            }
        }
        
        //starts the pink square
         private void bag6Switch_Tick(object sender, EventArgs e)
        {
            timerBag6.Start();
        }


        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage_LocationChanged(object sender, EventArgs e)
        {

            if (pb_luggage.Top >= this.Width)
            {
                pb_luggage.Top = 0 - pb_luggage.Height;
                pb_luggage.Left = 200;
            }

        }

        //triggers the bag stuck button, which stops the conveyer
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            secondBag.Stop();
            stuck = true;
            securityCheck.Stop();
            blink.Start();
        }
        
        //stops the blinking of the bag stuck button and starts the conveyer
        private void bagStuck_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            stuck = false;
            secondBag.Start();
            blink.Stop();
            bagStuck.BackColor = Color.Blue;
            timer2.Start();
        }

        //changes the color of the bag stuck button 
        private void blink_Tick(object sender, EventArgs e)
        {
            if (bagStuck.BackColor == Color.Black)
            {
                bagStuck.BackColor = Color.Red;
            }
            else
            {
                bagStuck.BackColor = Color.Black;
            }
        }


        //triggers the security check button, which sends the bag at the top left corner
        private void switchTimer_Tick(object sender, EventArgs e)
        {
            
            Timer_Game.Stop();
            blink2.Start();
            pb_luggage.Top = 0;
            pb_luggage.Left = 0;

        }
        
        //starts the timer which sets the time between the bags
        private void securityCheck_Tick(object sender, EventArgs e)
        {

            secondBag.Start();

        }
        
        //when you click on the security button it sends the seized bag back to the conveyer
        private void buttonSec_Click(object sender, EventArgs e)
        {

            switchTimer.Stop();
            pb_luggage.Visible = true;
            Timer_Game.Start();
            blink2.Stop();
            buttonSec.BackColor = Color.Blue;
            switchTimer.Start();

            
        }

        //changes the color of the security check button
        private void blink2_Tick(object sender, EventArgs e)
        {
            
            if (buttonSec.BackColor == Color.Black)
            {
                buttonSec.BackColor = Color.Red;
            }
            else
            {
                buttonSec.BackColor = Color.Black;
            }
            
        }
        
        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage2_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage2.Top >= this.Width)
            {
                pb_luggage2.Top = 0 - pb_luggage2.Height;
                pb_luggage2.Left = 200;
            }
        }
        
        //Slows down the bags in a specific speed
        private void button2_Click(object sender, EventArgs e)
        {
            Timer_Game.Interval = 50;
            secondBag.Interval = 50;
            thirdBag.Interval = 50;
        }

        //returns the speed of the bags into the predifined speed
        private void button1_Click(object sender, EventArgs e)
        {
            Timer_Game.Interval = 1;
            secondBag.Interval = 1;
            thirdBag.Interval = 1;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Top >= this.Width)
            {
                pictureBox1.Top = 0 - pictureBox1.Height;
                pictureBox1.Left = 200;
            }
        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage5_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage5.Top >= this.Width)
            {
                pb_luggage5.Top = 0 - pb_luggage5.Height;
                pb_luggage5.Left = 515;
            }
        }


        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage6_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage6.Top >= this.Width)
            {
                pb_luggage6.Top = 0 - pb_luggage6.Height;
                pb_luggage6.Left = 515;
            }
        }

        //This places the luggage at the starting point when it finishes the conveyer belt
        private void pb_luggage4_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage4.Top >= this.Width)
            {
                pb_luggage4.Top = 0 - pb_luggage4.Height;
                pb_luggage4.Left = 515;
            }
        }
        
        //starts the 2nd check in 
        private void button3_Click(object sender, EventArgs e)
        {
            pb_luggage4.Visible = true;
            pb_luggage5.Visible = true;
            pb_luggage6.Visible = true;
            timerBag4.Start();
            bag5Switch.Start();
            bag6Switch.Start();
        }

        //closes the 2nd check in
        private void CloseCheckIn_Click(object sender, EventArgs e)
        {
           
                timerBag4.Stop();
                bag5Switch.Stop();
                timerBag5.Stop();
                bag6Switch.Stop();
                timerBag6.Stop();
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
