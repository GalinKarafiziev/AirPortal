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
            this.Drop1 = new System.Windows.Forms.Timer(this.components);
            this.Drop2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckIn2 = new System.Windows.Forms.Button();
            this.labelDrop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDropoff2 = new System.Windows.Forms.GroupBox();
            this.lbPassenger2 = new System.Windows.Forms.Label();
            this.lbCheckIn2 = new System.Windows.Forms.Label();
            this.lbBags2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbDropoff1 = new System.Windows.Forms.GroupBox();
            this.lbPassenger = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.lbBags = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Passengers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBreak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTicketId = new System.Windows.Forms.Label();
            this.lbDropOffDes = new System.Windows.Forms.Label();
            this.lbBagId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDropoff2.SuspendLayout();
            this.gbDropoff1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drop1
            // 
            this.Drop1.Interval = 1000;
            this.Drop1.Tick += new System.EventHandler(this.Drop1_Tick);
            // 
            // Drop2
            // 
            this.Drop2.Interval = 2000;
            this.Drop2.Tick += new System.EventHandler(this.Drop2_Tick);
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
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
            // btnCheckIn2
            // 
            this.btnCheckIn2.BackColor = System.Drawing.Color.Blue;
            this.btnCheckIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCheckIn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckIn2.Location = new System.Drawing.Point(5, 277);
            this.btnCheckIn2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn2.Name = "btnCheckIn2";
            this.btnCheckIn2.Size = new System.Drawing.Size(217, 49);
            this.btnCheckIn2.TabIndex = 12;
            this.btnCheckIn2.Text = "Open check in 2";
            this.btnCheckIn2.UseVisualStyleBackColor = false;
            this.btnCheckIn2.Click += new System.EventHandler(this.btnCheckIn2_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDropoff2);
            this.groupBox1.Controls.Add(this.gbDropoff1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(804, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(755, 212);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // gbDropoff2
            // 
            this.gbDropoff2.Controls.Add(this.lbPassenger2);
            this.gbDropoff2.Controls.Add(this.lbCheckIn2);
            this.gbDropoff2.Controls.Add(this.lbBags2);
            this.gbDropoff2.Controls.Add(this.label11);
            this.gbDropoff2.Controls.Add(this.label13);
            this.gbDropoff2.Controls.Add(this.label14);
            this.gbDropoff2.Location = new System.Drawing.Point(437, 46);
            this.gbDropoff2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDropoff2.Name = "gbDropoff2";
            this.gbDropoff2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDropoff2.Size = new System.Drawing.Size(304, 148);
            this.gbDropoff2.TabIndex = 10;
            this.gbDropoff2.TabStop = false;
            this.gbDropoff2.Text = "Dropoff 2";
            // 
            // lbPassenger2
            // 
            this.lbPassenger2.AutoSize = true;
            this.lbPassenger2.Location = new System.Drawing.Point(173, 114);
            this.lbPassenger2.Name = "lbPassenger2";
            this.lbPassenger2.Size = new System.Drawing.Size(18, 20);
            this.lbPassenger2.TabIndex = 7;
            this.lbPassenger2.Text = "0";
            // 
            // lbCheckIn2
            // 
            this.lbCheckIn2.AutoSize = true;
            this.lbCheckIn2.Location = new System.Drawing.Point(173, 76);
            this.lbCheckIn2.Name = "lbCheckIn2";
            this.lbCheckIn2.Size = new System.Drawing.Size(18, 20);
            this.lbCheckIn2.TabIndex = 6;
            this.lbCheckIn2.Text = "0";
            // 
            // lbBags2
            // 
            this.lbBags2.AutoSize = true;
            this.lbBags2.Location = new System.Drawing.Point(173, 38);
            this.lbBags2.Name = "lbBags2";
            this.lbBags2.Size = new System.Drawing.Size(18, 20);
            this.lbBags2.TabIndex = 5;
            this.lbBags2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bags Arrived";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Check In/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Passengers";
            // 
            // gbDropoff1
            // 
            this.gbDropoff1.Controls.Add(this.lbPassenger);
            this.gbDropoff1.Controls.Add(this.lbCheckIn);
            this.gbDropoff1.Controls.Add(this.lbBags);
            this.gbDropoff1.Controls.Add(this.label6);
            this.gbDropoff1.Controls.Add(this.label7);
            this.gbDropoff1.Controls.Add(this.Passengers);
            this.gbDropoff1.Location = new System.Drawing.Point(19, 46);
            this.gbDropoff1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDropoff1.Name = "gbDropoff1";
            this.gbDropoff1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDropoff1.Size = new System.Drawing.Size(304, 148);
            this.gbDropoff1.TabIndex = 4;
            this.gbDropoff1.TabStop = false;
            this.gbDropoff1.Text = "Dropoff 1";
            // 
            // lbPassenger
            // 
            this.lbPassenger.AutoSize = true;
            this.lbPassenger.Location = new System.Drawing.Point(173, 114);
            this.lbPassenger.Name = "lbPassenger";
            this.lbPassenger.Size = new System.Drawing.Size(18, 20);
            this.lbPassenger.TabIndex = 7;
            this.lbPassenger.Text = "0";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Location = new System.Drawing.Point(173, 76);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(18, 20);
            this.lbCheckIn.TabIndex = 6;
            this.lbCheckIn.Text = "0";
            // 
            // lbBags
            // 
            this.lbBags.AutoSize = true;
            this.lbBags.Location = new System.Drawing.Point(173, 38);
            this.lbBags.Name = "lbBags";
            this.lbBags.Size = new System.Drawing.Size(18, 20);
            this.lbBags.TabIndex = 5;
            this.lbBags.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bags Arrived";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Check In/s";
            // 
            // Passengers
            // 
            this.Passengers.AutoSize = true;
            this.Passengers.Location = new System.Drawing.Point(5, 114);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(98, 20);
            this.Passengers.TabIndex = 2;
            this.Passengers.Text = "Passengers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 27;
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.Blue;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnBreak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBreak.Location = new System.Drawing.Point(5, 379);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(4);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(217, 36);
            this.btnBreak.TabIndex = 28;
            this.btnBreak.Text = "Break/Release Conveyors";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBagId);
            this.groupBox2.Controls.Add(this.lbDropOffDes);
            this.groupBox2.Controls.Add(this.lbTicketId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(804, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 239);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Bag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Destanation Drop Off:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Passenger Ticket ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bag Id:";
            // 
            // lbTicketId
            // 
            this.lbTicketId.AutoSize = true;
            this.lbTicketId.Location = new System.Drawing.Point(182, 110);
            this.lbTicketId.Name = "lbTicketId";
            this.lbTicketId.Size = new System.Drawing.Size(72, 17);
            this.lbTicketId.TabIndex = 3;
            this.lbTicketId.Text = "SelectBag";
            // 
            // lbDropOffDes
            // 
            this.lbDropOffDes.AutoSize = true;
            this.lbDropOffDes.Location = new System.Drawing.Point(182, 154);
            this.lbDropOffDes.Name = "lbDropOffDes";
            this.lbDropOffDes.Size = new System.Drawing.Size(72, 17);
            this.lbDropOffDes.TabIndex = 4;
            this.lbDropOffDes.Text = "SelectBag";
            // 
            // lbBagId
            // 
            this.lbBagId.AutoSize = true;
            this.lbBagId.Location = new System.Drawing.Point(182, 65);
            this.lbBagId.Name = "lbBagId";
            this.lbBagId.Size = new System.Drawing.Size(72, 17);
            this.lbBagId.TabIndex = 5;
            this.lbBagId.Text = "SelectBag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1568, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDrop);
            this.Controls.Add(this.btnCheckIn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.gbDropoff2.ResumeLayout(false);
            this.gbDropoff2.PerformLayout();
            this.gbDropoff1.ResumeLayout(false);
            this.gbDropoff1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Drop1;
        private System.Windows.Forms.Timer Drop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckIn2;
        private System.Windows.Forms.Label labelDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDropoff2;
        private System.Windows.Forms.Label lbPassenger2;
        private System.Windows.Forms.Label lbCheckIn2;
        private System.Windows.Forms.Label lbBags2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbDropoff1;
        private System.Windows.Forms.Label lbPassenger;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Label lbBags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Passengers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbBagId;
        private System.Windows.Forms.Label lbDropOffDes;
        private System.Windows.Forms.Label lbTicketId;
    }
}

