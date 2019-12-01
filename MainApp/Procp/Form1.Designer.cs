namespace Procp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer_Game = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bagStuck = new System.Windows.Forms.Button();
            this.blink = new System.Windows.Forms.Timer(this.components);
            this.switchTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonSec = new System.Windows.Forms.Button();
            this.blink2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerBag4 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.CloseCheckIn = new System.Windows.Forms.Button();
            this.labelDrop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_luggage5 = new System.Windows.Forms.PictureBox();
            this.pb_luggage6 = new System.Windows.Forms.PictureBox();
            this.pb_luggage4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.pb_luggage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Game
            // 
            this.Timer_Game.Interval = 1000;
            this.Timer_Game.Tick += new System.EventHandler(this.Timer_Game_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bagStuck
            // 
            this.bagStuck.BackColor = System.Drawing.Color.Blue;
            this.bagStuck.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagStuck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bagStuck.Location = new System.Drawing.Point(5, 377);
            this.bagStuck.Margin = new System.Windows.Forms.Padding(4);
            this.bagStuck.Name = "bagStuck";
            this.bagStuck.Size = new System.Drawing.Size(103, 62);
            this.bagStuck.TabIndex = 2;
            this.bagStuck.Text = "Bag Stuck";
            this.bagStuck.UseVisualStyleBackColor = false;
            this.bagStuck.Click += new System.EventHandler(this.bagStuck_Click);
            // 
            // blink
            // 
            this.blink.Tick += new System.EventHandler(this.blink_Tick);
            // 
            // switchTimer
            // 
            this.switchTimer.Interval = 1000;
            this.switchTimer.Tick += new System.EventHandler(this.switchTimer_Tick);
            // 
            // buttonSec
            // 
            this.buttonSec.BackColor = System.Drawing.Color.Blue;
            this.buttonSec.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonSec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSec.Location = new System.Drawing.Point(119, 378);
            this.buttonSec.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(103, 62);
            this.buttonSec.TabIndex = 3;
            this.buttonSec.Text = "SECURITY!";
            this.buttonSec.UseVisualStyleBackColor = false;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // blink2
            // 
            this.blink2.Tick += new System.EventHandler(this.blink2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEIZED";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(5, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Slow Down Conveyer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(119, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "return speed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerBag4
            // 
            this.timerBag4.Tick += new System.EventHandler(this.timerBag4_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(5, 277);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Open check in";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseCheckIn
            // 
            this.CloseCheckIn.BackColor = System.Drawing.Color.Blue;
            this.CloseCheckIn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CloseCheckIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseCheckIn.Location = new System.Drawing.Point(119, 277);
            this.CloseCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseCheckIn.Name = "CloseCheckIn";
            this.CloseCheckIn.Size = new System.Drawing.Size(103, 49);
            this.CloseCheckIn.TabIndex = 13;
            this.CloseCheckIn.Text = "Close Check In";
            this.CloseCheckIn.UseVisualStyleBackColor = false;
            this.CloseCheckIn.Click += new System.EventHandler(this.CloseCheckIn_Click);
            // 
            // labelDrop
            // 
            this.labelDrop.AutoSize = true;
            this.labelDrop.BackColor = System.Drawing.Color.Transparent;
            this.labelDrop.Location = new System.Drawing.Point(9, 449);
            this.labelDrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrop.Name = "labelDrop";
            this.labelDrop.Size = new System.Drawing.Size(87, 17);
            this.labelDrop.TabIndex = 15;
            this.labelDrop.Text = "DROP OFF1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(683, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "DROP OFF2";
            // 
            // pb_luggage5
            // 
            this.pb_luggage5.BackColor = System.Drawing.Color.Teal;
            this.pb_luggage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_luggage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_luggage5.Location = new System.Drawing.Point(687, 0);
            this.pb_luggage5.Margin = new System.Windows.Forms.Padding(4);
            this.pb_luggage5.Name = "pb_luggage5";
            this.pb_luggage5.Size = new System.Drawing.Size(66, 61);
            this.pb_luggage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_luggage5.TabIndex = 11;
            this.pb_luggage5.TabStop = false;
            this.pb_luggage5.LocationChanged += new System.EventHandler(this.pb_luggage5_LocationChanged);
            this.pb_luggage5.Click += new System.EventHandler(this.pb_luggage5_Click);
            // 
            // pb_luggage6
            // 
            this.pb_luggage6.BackColor = System.Drawing.Color.Magenta;
            this.pb_luggage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_luggage6.Location = new System.Drawing.Point(687, 0);
            this.pb_luggage6.Margin = new System.Windows.Forms.Padding(4);
            this.pb_luggage6.Name = "pb_luggage6";
            this.pb_luggage6.Size = new System.Drawing.Size(66, 61);
            this.pb_luggage6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_luggage6.TabIndex = 10;
            this.pb_luggage6.TabStop = false;
            this.pb_luggage6.LocationChanged += new System.EventHandler(this.pb_luggage6_LocationChanged);
            // 
            // pb_luggage4
            // 
            this.pb_luggage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pb_luggage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_luggage4.Location = new System.Drawing.Point(687, 0);
            this.pb_luggage4.Margin = new System.Windows.Forms.Padding(4);
            this.pb_luggage4.Name = "pb_luggage4";
            this.pb_luggage4.Size = new System.Drawing.Size(66, 61);
            this.pb_luggage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_luggage4.TabIndex = 9;
            this.pb_luggage4.TabStop = false;
            this.pb_luggage4.LocationChanged += new System.EventHandler(this.pb_luggage4_LocationChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(267, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.LocationChanged += new System.EventHandler(this.pictureBox1_LocationChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Green;
            this.b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b.Location = new System.Drawing.Point(267, 0);
            this.b.Margin = new System.Windows.Forms.Padding(4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(66, 61);
            this.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b.TabIndex = 1;
            this.b.TabStop = false;
            this.b.Visible = false;
            this.b.LocationChanged += new System.EventHandler(this.pb_luggage2_LocationChanged);
            // 
            // pb_luggage
            // 
            this.pb_luggage.BackColor = System.Drawing.Color.Red;
            this.pb_luggage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_luggage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_luggage.Location = new System.Drawing.Point(267, 0);
            this.pb_luggage.Margin = new System.Windows.Forms.Padding(4);
            this.pb_luggage.Name = "pb_luggage";
            this.pb_luggage.Size = new System.Drawing.Size(66, 61);
            this.pb_luggage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_luggage.TabIndex = 0;
            this.pb_luggage.TabStop = false;
            this.pb_luggage.Visible = false;
            this.pb_luggage.LocationChanged += new System.EventHandler(this.pb_luggage_LocationChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(263, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "CHECK IN1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(683, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "CHECK IN2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 668);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 666);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDrop);
            this.Controls.Add(this.CloseCheckIn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pb_luggage5);
            this.Controls.Add(this.pb_luggage6);
            this.Controls.Add(this.pb_luggage4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSec);
            this.Controls.Add(this.bagStuck);
            this.Controls.Add(this.pb_luggage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luggage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_luggage;
        private System.Windows.Forms.Timer Timer_Game;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bagStuck;
        private System.Windows.Forms.Timer blink;
        private System.Windows.Forms.Timer switchTimer;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Timer blink2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_luggage4;
        private System.Windows.Forms.PictureBox pb_luggage6;
        private System.Windows.Forms.PictureBox pb_luggage5;
        private System.Windows.Forms.Timer timerBag4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseCheckIn;
        private System.Windows.Forms.Label labelDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

