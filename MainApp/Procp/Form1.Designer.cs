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
            this.CheckIn1Timer = new System.Windows.Forms.Timer(this.components);
            this.CheckIn2Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckIn2 = new System.Windows.Forms.Button();
            this.lbDrop1 = new System.Windows.Forms.Label();
            this.lbDrop2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPassenger3 = new System.Windows.Forms.Label();
            this.lbCheckIn3 = new System.Windows.Forms.Label();
            this.lbBags3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbDropoff2 = new System.Windows.Forms.GroupBox();
            this.lbPassenger2 = new System.Windows.Forms.Label();
            this.lbCheckIn2 = new System.Windows.Forms.Label();
            this.lbBags2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbDropoff1 = new System.Windows.Forms.GroupBox();
            this.lbPassenger1 = new System.Windows.Forms.Label();
            this.lbCheckIn1 = new System.Windows.Forms.Label();
            this.lbBags1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Passengers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBreak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtimerS = new System.Windows.Forms.Label();
            this.lbBaggy = new System.Windows.Forms.Label();
            this.lbDropOffDes = new System.Windows.Forms.Label();
            this.lbTicketId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Check1NewCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDrop3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lbDrop4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCheckIn3 = new System.Windows.Forms.Button();
            this.btnCheckIn4 = new System.Windows.Forms.Button();
            this.CheckIn3Timer = new System.Windows.Forms.Timer(this.components);
            this.CheckIn4Timer = new System.Windows.Forms.Timer(this.components);
            this.Check2NewCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.Check3NewCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.Check4NewCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDropoff2.SuspendLayout();
            this.gbDropoff1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckIn1Timer
            // 
            this.CheckIn1Timer.Interval = 2000;
            this.CheckIn1Timer.Tick += new System.EventHandler(this.CheckIn1_Tick);
            // 
            // CheckIn2Timer
            // 
            this.CheckIn2Timer.Interval = 2000;
            this.CheckIn2Timer.Tick += new System.EventHandler(this.CheckIn2_Tick);
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
            this.button2.Location = new System.Drawing.Point(13, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.button1.Location = new System.Drawing.Point(125, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCheckIn2.Location = new System.Drawing.Point(13, 292);
            this.btnCheckIn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn2.Name = "btnCheckIn2";
            this.btnCheckIn2.Size = new System.Drawing.Size(217, 49);
            this.btnCheckIn2.TabIndex = 12;
            this.btnCheckIn2.Text = "Open check in 2";
            this.btnCheckIn2.UseVisualStyleBackColor = false;
            this.btnCheckIn2.Click += new System.EventHandler(this.btnCheckIn2_Click);
            // 
            // lbDrop1
            // 
            this.lbDrop1.AutoSize = true;
            this.lbDrop1.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop1.Location = new System.Drawing.Point(263, 606);
            this.lbDrop1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrop1.Name = "lbDrop1";
            this.lbDrop1.Size = new System.Drawing.Size(79, 17);
            this.lbDrop1.TabIndex = 15;
            this.lbDrop1.Text = "DROP OFF";
            // 
            // lbDrop2
            // 
            this.lbDrop2.AutoSize = true;
            this.lbDrop2.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop2.Location = new System.Drawing.Point(476, 606);
            this.lbDrop2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrop2.Name = "lbDrop2";
            this.lbDrop2.Size = new System.Drawing.Size(79, 17);
            this.lbDrop2.TabIndex = 21;
            this.lbDrop2.Text = "DROP OFF";
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
            this.label4.Location = new System.Drawing.Point(476, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "CHECK IN2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbDropoff2);
            this.groupBox1.Controls.Add(this.gbDropoff1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1165, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(755, 354);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPassenger3);
            this.groupBox3.Controls.Add(this.lbCheckIn3);
            this.groupBox3.Controls.Add(this.lbBags3);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(223, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(304, 148);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dropoff 3";
            // 
            // lbPassenger3
            // 
            this.lbPassenger3.AutoSize = true;
            this.lbPassenger3.Location = new System.Drawing.Point(173, 114);
            this.lbPassenger3.Name = "lbPassenger3";
            this.lbPassenger3.Size = new System.Drawing.Size(18, 20);
            this.lbPassenger3.TabIndex = 7;
            this.lbPassenger3.Text = "0";
            // 
            // lbCheckIn3
            // 
            this.lbCheckIn3.AutoSize = true;
            this.lbCheckIn3.Location = new System.Drawing.Point(173, 76);
            this.lbCheckIn3.Name = "lbCheckIn3";
            this.lbCheckIn3.Size = new System.Drawing.Size(18, 20);
            this.lbCheckIn3.TabIndex = 6;
            this.lbCheckIn3.Text = "0";
            // 
            // lbBags3
            // 
            this.lbBags3.AutoSize = true;
            this.lbBags3.Location = new System.Drawing.Point(173, 38);
            this.lbBags3.Name = "lbBags3";
            this.lbBags3.Size = new System.Drawing.Size(18, 20);
            this.lbBags3.TabIndex = 5;
            this.lbBags3.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Bags Arrived";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Check In/s";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Passengers";
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
            this.gbDropoff1.Controls.Add(this.lbPassenger1);
            this.gbDropoff1.Controls.Add(this.lbCheckIn1);
            this.gbDropoff1.Controls.Add(this.lbBags1);
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
            // lbPassenger1
            // 
            this.lbPassenger1.AutoSize = true;
            this.lbPassenger1.Location = new System.Drawing.Point(173, 114);
            this.lbPassenger1.Name = "lbPassenger1";
            this.lbPassenger1.Size = new System.Drawing.Size(18, 20);
            this.lbPassenger1.TabIndex = 7;
            this.lbPassenger1.Text = "0";
            // 
            // lbCheckIn1
            // 
            this.lbCheckIn1.AutoSize = true;
            this.lbCheckIn1.Location = new System.Drawing.Point(173, 76);
            this.lbCheckIn1.Name = "lbCheckIn1";
            this.lbCheckIn1.Size = new System.Drawing.Size(18, 20);
            this.lbCheckIn1.TabIndex = 6;
            this.lbCheckIn1.Text = "0";
            // 
            // lbBags1
            // 
            this.lbBags1.AutoSize = true;
            this.lbBags1.Location = new System.Drawing.Point(173, 38);
            this.lbBags1.Name = "lbBags1";
            this.lbBags1.Size = new System.Drawing.Size(18, 20);
            this.lbBags1.TabIndex = 5;
            this.lbBags1.Text = "0";
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
            this.btnBreak.Location = new System.Drawing.Point(13, 519);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(217, 36);
            this.btnBreak.TabIndex = 28;
            this.btnBreak.Text = "Break/Release Conveyors";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtimerS);
            this.groupBox2.Controls.Add(this.lbBaggy);
            this.groupBox2.Controls.Add(this.lbDropOffDes);
            this.groupBox2.Controls.Add(this.lbTicketId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(1288, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(351, 239);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Bag";
            // 
            // lbtimerS
            // 
            this.lbtimerS.AutoSize = true;
            this.lbtimerS.Location = new System.Drawing.Point(261, 32);
            this.lbtimerS.Name = "lbtimerS";
            this.lbtimerS.Size = new System.Drawing.Size(52, 17);
            this.lbtimerS.TabIndex = 7;
            this.lbtimerS.Text = "Bag Id:";
            // 
            // lbBaggy
            // 
            this.lbBaggy.AutoSize = true;
            this.lbBaggy.Location = new System.Drawing.Point(177, 65);
            this.lbBaggy.Name = "lbBaggy";
            this.lbBaggy.Size = new System.Drawing.Size(72, 17);
            this.lbBaggy.TabIndex = 6;
            this.lbBaggy.Text = "SelectBag";
            // 
            // lbDropOffDes
            // 
            this.lbDropOffDes.AutoSize = true;
            this.lbDropOffDes.Location = new System.Drawing.Point(181, 154);
            this.lbDropOffDes.Name = "lbDropOffDes";
            this.lbDropOffDes.Size = new System.Drawing.Size(72, 17);
            this.lbDropOffDes.TabIndex = 4;
            this.lbDropOffDes.Text = "SelectBag";
            // 
            // lbTicketId
            // 
            this.lbTicketId.AutoSize = true;
            this.lbTicketId.Location = new System.Drawing.Point(181, 110);
            this.lbTicketId.Name = "lbTicketId";
            this.lbTicketId.Size = new System.Drawing.Size(72, 17);
            this.lbTicketId.TabIndex = 3;
            this.lbTicketId.Text = "SelectBag";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(689, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "CHECK IN3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(903, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "CHECK IN4";
            // 
            // lbDrop3
            // 
            this.lbDrop3.AutoSize = true;
            this.lbDrop3.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop3.Location = new System.Drawing.Point(689, 606);
            this.lbDrop3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrop3.Name = "lbDrop3";
            this.lbDrop3.Size = new System.Drawing.Size(79, 17);
            this.lbDrop3.TabIndex = 32;
            this.lbDrop3.Text = "DROP OFF";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox2.Location = new System.Drawing.Point(372, 11);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 24);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.Text = "dropoff1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox3.Location = new System.Drawing.Point(587, 11);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 24);
            this.comboBox3.TabIndex = 43;
            this.comboBox3.Text = "dropoff1";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox4.Location = new System.Drawing.Point(799, 11);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 24);
            this.comboBox4.TabIndex = 44;
            this.comboBox4.Text = "dropoff1";
            // 
            // lbDrop4
            // 
            this.lbDrop4.AutoSize = true;
            this.lbDrop4.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop4.Location = new System.Drawing.Point(903, 606);
            this.lbDrop4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrop4.Name = "lbDrop4";
            this.lbDrop4.Size = new System.Drawing.Size(79, 17);
            this.lbDrop4.TabIndex = 45;
            this.lbDrop4.Text = "DROP OFF";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Blue;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(16, 198);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 75);
            this.btnStart.TabIndex = 46;
            this.btnStart.Text = "Start Simulation And Check In 1";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox1.Location = new System.Drawing.Point(163, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Text = "dropoff1";
            // 
            // btnCheckIn3
            // 
            this.btnCheckIn3.BackColor = System.Drawing.Color.Blue;
            this.btnCheckIn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCheckIn3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckIn3.Location = new System.Drawing.Point(16, 354);
            this.btnCheckIn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn3.Name = "btnCheckIn3";
            this.btnCheckIn3.Size = new System.Drawing.Size(217, 49);
            this.btnCheckIn3.TabIndex = 48;
            this.btnCheckIn3.Text = "Open check in 3";
            this.btnCheckIn3.UseVisualStyleBackColor = false;
            this.btnCheckIn3.Click += new System.EventHandler(this.btnCheckIn3_Click_1);
            // 
            // btnCheckIn4
            // 
            this.btnCheckIn4.BackColor = System.Drawing.Color.Blue;
            this.btnCheckIn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCheckIn4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckIn4.Location = new System.Drawing.Point(16, 416);
            this.btnCheckIn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn4.Name = "btnCheckIn4";
            this.btnCheckIn4.Size = new System.Drawing.Size(217, 49);
            this.btnCheckIn4.TabIndex = 49;
            this.btnCheckIn4.Text = "Open check in 4";
            this.btnCheckIn4.UseVisualStyleBackColor = false;
            this.btnCheckIn4.Click += new System.EventHandler(this.btnCheckIn4_Click);
            // 
            // CheckIn3Timer
            // 
            this.CheckIn3Timer.Interval = 2000;
            this.CheckIn3Timer.Tick += new System.EventHandler(this.CheckIn3Timer_Tick);
            // 
            // CheckIn4Timer
            // 
            this.CheckIn4Timer.Interval = 2000;
            this.CheckIn4Timer.Tick += new System.EventHandler(this.CheckIn4Timer_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1697, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 50;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1697, 432);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 51;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1697, 473);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 52;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1715, 551);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "label15";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1697, 508);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 54;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 670);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCheckIn4);
            this.Controls.Add(this.btnCheckIn3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbDrop4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbDrop3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDrop2);
            this.Controls.Add(this.lbDrop1);
            this.Controls.Add(this.btnCheckIn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Timer CheckIn1Timer;
        private System.Windows.Forms.Timer CheckIn2Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckIn2;
        private System.Windows.Forms.Label lbDrop1;
        private System.Windows.Forms.Label lbDrop2;
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
        private System.Windows.Forms.Label lbPassenger1;
        private System.Windows.Forms.Label lbCheckIn1;
        private System.Windows.Forms.Label lbBags1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Passengers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDropOffDes;
        private System.Windows.Forms.Label lbTicketId;
        private System.Windows.Forms.Label lbBaggy;
        private System.Windows.Forms.Timer Check1NewCheckTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDrop3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lbDrop4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCheckIn3;
        private System.Windows.Forms.Button btnCheckIn4;
        private System.Windows.Forms.Label lbtimerS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbPassenger3;
        private System.Windows.Forms.Label lbCheckIn3;
        private System.Windows.Forms.Label lbBags3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer CheckIn3Timer;
        private System.Windows.Forms.Timer CheckIn4Timer;
        private System.Windows.Forms.Timer Check2NewCheckTimer;
        private System.Windows.Forms.Timer Check3NewCheckTimer;
        private System.Windows.Forms.Timer Check4NewCheckTimer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
    }
}

