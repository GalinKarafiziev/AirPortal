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
        public bool stuck = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Game.Interval = 1;
           
            Timer_Game.Start();
            secondBag.Interval = 1;
            thirdBag.Interval = 1;
            timerBag4.Interval = 1;
            
            timerBag5.Interval = 1;
            timerBag6.Interval = 1;
            timer2.Interval = 14100;
            timer2.Start();

           
            securityCheck.Interval = 1000;
            securityCheck.Start();
            switchTimer.Interval = 11200;
            switchTimer.Start();
            thirdBagSwitch.Interval = 2000;
            thirdBagSwitch.Start();
            bag5Switch.Interval = 1000;
            
            bag6Switch.Interval = 2000;
            pb_luggage4.Visible = false;
            pb_luggage5.Visible = false;
            pb_luggage6.Visible = false;
            dropoff1.Visible = false;
            dropoff2.Visible = false;
            dropoff3.Visible = false;
            dropoff5.Visible = false;
            dropoff6.Visible = false;
            dropoff4.Visible = false;
            dropoff.Interval = 50;
            
            dropofftimer1.Interval = 50;
            dropofftimer2.Interval = 50;
            dropofftimer4.Interval = 50;
            dropofftimer5.Interval = 50;
            dropofftimer6.Interval = 50;
        }

        private void Timer_Game_Tick(object sender, EventArgs e)
        {
            if (stuck == true)
            {
                pictureBox1.Top += 0;
            }
            else
            {
                if (pb_luggage.Top < 60)
                {
                    pb_luggage.Top += 2;
                    //  pb_luggage5.Top += 2;
                }
                else if (pb_luggage.Top < 390 && pb_luggage.Left < 200)
                {
                    pb_luggage.Left += 2;
                    //  pb_luggage5.Left += 2;
                }
                else
                {
                    if (pb_luggage.Top > 390 && pb_luggage.Left > 10)
                    {
                        pb_luggage.Left -= 2;
                        // pb_luggage4.Top += 2;
                    }
                    else
                    {
                        pb_luggage.Top += 2;
                    }
                }
            }
        /*
            if(pb_luggage2.Top < 60 && pb_luggage.Top > 60)
            {
                pb_luggage2.Top += 2;
            }
            else if(pb_luggage2.Left < 200 && pb_luggage.Left > 200)
            {
                pb_luggage2.Left += 2;
            }
            else if( pb_luggage2.Left > 200)
            {
                pb_luggage2.Top += 2;
            }
          */
            
        }

        private void secondBag_Tick(object sender, EventArgs e)
        {

            if (pb_luggage2.Top < 60)
            {
                pb_luggage2.Top += 2;
                //  pb_luggage5.Top += 2;
            }
            else if (pb_luggage2.Top < 390 && pb_luggage2.Left < 200)
            {
                pb_luggage2.Left += 2;
                //  pb_luggage5.Left += 2;
            }
            else {
                if (pb_luggage2.Top > 390 && pb_luggage2.Left > 10)
                {
                    pb_luggage2.Left -= 2;
                    // pb_luggage4.Top += 2;
                }
                else
                {
                    pb_luggage2.Top += 2;
                }
            }
        }

        private void pb_luggage_LocationChanged(object sender, EventArgs e)
        {
         
            if ( pb_luggage.Top >= this.Width)
            {
                pb_luggage.Top = 0 - pb_luggage.Height;
                pb_luggage.Left = 200;
                dropofftimer4.Start();
            }
         /*   if (pb_luggage2.Top >= this.Width)
            {
                pb_luggage2.Top = 0 - pb_luggage2.Height;
                pb_luggage2.Left = 75;
            }
            */
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            secondBag.Stop();
            stuck = true;
            securityCheck.Stop();
            blink.Start();
        }

        private void bagStuck_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            stuck = false;
            secondBag.Start();
            blink.Stop();
            bagStuck.BackColor = Color.Blue;
            timer2.Start();
        }


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



        private void switchTimer_Tick(object sender, EventArgs e)
        {
            //  securityCheck.Start();
            Timer_Game.Stop();
            blink2.Start();
            pb_luggage.Top = 0;
            pb_luggage.Left = 0;

        }

        private void securityCheck_Tick(object sender, EventArgs e)
        {

            secondBag.Start();


            /*     Timer_Game.Stop();
                 blink2.Start();
                 if (pb_luggage2.Top < 60)
                 {
                     pb_luggage2.Top += 2;
                 }
                 else if (pb_luggage2.Left < 200 )
                 {
                     pb_luggage2.Left += 2;
                 }
                 else if (pb_luggage2.Left > 200)
                 {
                     pb_luggage2.Top += 2;
                 }
               */

        }
        

        private void buttonSec_Click(object sender, EventArgs e)
        {

            switchTimer.Stop();
            pb_luggage.Visible = true;
            Timer_Game.Start();
            blink2.Stop();
            buttonSec.BackColor = Color.Blue;
            switchTimer.Start();

            
        }

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

        private void pb_luggage2_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage2.Top >= this.Width)
            {
                pb_luggage2.Top = 0 - pb_luggage2.Height;
                pb_luggage2.Left = 200;
                dropofftimer5.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer_Game.Interval = 50;
            secondBag.Interval = 50;
            thirdBag.Interval = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer_Game.Interval = 1;
            secondBag.Interval = 1;
            thirdBag.Interval = 1;
        }

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
                    //  pb_luggage5.Top += 2;
                }
                else if (pictureBox1.Top < 390 && pictureBox1.Left < 200)
                {
                    pictureBox1.Left += 2;
                    //  pb_luggage5.Left += 2;
                }
                else
                {
                    if (pictureBox1.Top > 390 && pictureBox1.Left > 10)
                    {
                        pictureBox1.Left -= 2;
                        // pb_luggage4.Top += 2;
                    }
                    else
                    {
                        pictureBox1.Top += 2;
                    }
                }
            }
        }

        private void thirdBagSwitch_Tick(object sender, EventArgs e)
        {
            thirdBag.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Top >= this.Width)
            {
                pictureBox1.Top = 0 - pictureBox1.Height;
                pictureBox1.Left = 200;
                dropofftimer6.Start();
            }
        }

        private void pb_luggage5_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage5.Top >= this.Width)
            {
                pb_luggage5.Top = 0 - pb_luggage5.Height;
                pb_luggage5.Left = 515;
                // dropoff5.Visible = true;
                dropofftimer1.Start();
            }
        }

        private void pb_luggage6_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage6.Top >= this.Width)
            {
                pb_luggage6.Top = 0 - pb_luggage6.Height;
                pb_luggage6.Left = 515;
                dropofftimer2.Start();
            }
        }

        private void pb_luggage4_LocationChanged(object sender, EventArgs e)
        {
            if (pb_luggage4.Top >= this.Width)
            {
                pb_luggage4.Top = 0 - pb_luggage4.Height;
                pb_luggage4.Left = 515;
                dropoff.Start();
            }
        }

        private void dropoff_Tick(object sender, EventArgs e)
        {
            dropofftimer2.Stop();
            dropoff6.Visible = false;
            dropoff4.Visible = true;
        }

        private void dropofftimer1_Tick(object sender, EventArgs e)
        {
            dropoff.Stop();
            dropoff4.Visible = false;
            dropoff5.Visible = true;
        }
        private void dropofftimer2_Tick(object sender, EventArgs e)
        {
            dropofftimer1.Stop();
            dropoff5.Visible = false;
            dropoff6.Visible = true;
        }

        private void dropofftimer4_Tick(object sender, EventArgs e)
        {
            dropofftimer6.Stop();
            dropoff3.Visible = false;
            dropoff1.Visible = true;
        }

        private void dropofftimer5_Tick(object sender, EventArgs e)
        {
            dropofftimer4.Stop();
            dropoff1.Visible = false;
            dropoff2.Visible = true;
        }

        private void dropofftimer6_Tick(object sender, EventArgs e)
        {
            dropofftimer5.Stop();
            dropoff2.Visible = false;
            dropoff3.Visible = true;
        }



        private void bag5Switch_Tick(object sender, EventArgs e)
        {
            
            timerBag5.Start();
        }

        private void bag6Switch_Tick(object sender, EventArgs e)
        {
            timerBag6.Start();
        }

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
                    // pb_luggage4.Top += 2;
                }
                else
                {
                    pb_luggage4.Top += 2;
                }
            }
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            pb_luggage4.Visible = true;
            pb_luggage5.Visible = true;
            pb_luggage6.Visible = true;
            timerBag4.Start();
            bag5Switch.Start();
            bag6Switch.Start();
        }

        private void CloseCheckIn_Click(object sender, EventArgs e)
        {
           
                timerBag4.Stop();
                bag5Switch.Stop();
                timerBag5.Stop();
                bag6Switch.Stop();
                timerBag6.Stop();
            
           // timerBag5.Stop();
             //   bag6Switch.Stop();
                //timerBag6.Stop();
                // dropoff.Start();
        }

        private void dropoff5_Click(object sender, EventArgs e)
        {

        }

        private void dropoff6_Click(object sender, EventArgs e)
        {

        }

        private void dropoff4_Click(object sender, EventArgs e)
        {

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
