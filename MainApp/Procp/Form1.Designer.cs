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
            this.CheckIn1 = new System.Windows.Forms.Timer(this.components);
            this.CheckIn2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckIn2 = new System.Windows.Forms.Button();
            this.lbDrop1 = new System.Windows.Forms.Label();
            this.lbDrop2 = new System.Windows.Forms.Label();
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
            this.lbBaggy = new System.Windows.Forms.Label();
            this.lbBagId = new System.Windows.Forms.Label();
            this.lbDropOffDes = new System.Windows.Forms.Label();
            this.lbTicketId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drop1NewCheck = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDropoff2.SuspendLayout();
            this.gbDropoff1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckIn1
            // 
            this.CheckIn1.Interval = 1000;
            this.CheckIn1.Tick += new System.EventHandler(this.CheckIn1_Tick);
            // 
            // CheckIn2
            // 
            this.CheckIn2.Interval = 2000;
            this.CheckIn2.Tick += new System.EventHandler(this.CheckIn2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEIZED";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 29);
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
            this.button1.Location = new System.Drawing.Point(97, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
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
            this.btnCheckIn2.Location = new System.Drawing.Point(12, 236);
            this.btnCheckIn2.Name = "btnCheckIn2";
            this.btnCheckIn2.Size = new System.Drawing.Size(163, 40);
            this.btnCheckIn2.TabIndex = 12;
            this.btnCheckIn2.Text = "Open check in 2";
            this.btnCheckIn2.UseVisualStyleBackColor = false;
            this.btnCheckIn2.Click += new System.EventHandler(this.btnCheckIn2_Click);
            // 
            // lbDrop1
            // 
            this.lbDrop1.AutoSize = true;
            this.lbDrop1.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop1.Location = new System.Drawing.Point(197, 492);
            this.lbDrop1.Name = "lbDrop1";
            this.lbDrop1.Size = new System.Drawing.Size(67, 13);
            this.lbDrop1.TabIndex = 15;
            this.lbDrop1.Text = "DROP OFF1";
            // 
            // lbDrop2
            // 
            this.lbDrop2.AutoSize = true;
            this.lbDrop2.BackColor = System.Drawing.Color.Transparent;
            this.lbDrop2.Location = new System.Drawing.Point(357, 492);
            this.lbDrop2.Name = "lbDrop2";
            this.lbDrop2.Size = new System.Drawing.Size(67, 13);
            this.lbDrop2.TabIndex = 21;
            this.lbDrop2.Text = "DROP OFF3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(197, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "CHECK IN1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(357, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "CHECK IN2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDropoff2);
            this.groupBox1.Controls.Add(this.gbDropoff1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(966, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(566, 172);
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
            this.gbDropoff2.Location = new System.Drawing.Point(328, 37);
            this.gbDropoff2.Margin = new System.Windows.Forms.Padding(2);
            this.gbDropoff2.Name = "gbDropoff2";
            this.gbDropoff2.Padding = new System.Windows.Forms.Padding(2);
            this.gbDropoff2.Size = new System.Drawing.Size(228, 120);
            this.gbDropoff2.TabIndex = 10;
            this.gbDropoff2.TabStop = false;
            this.gbDropoff2.Text = "Dropoff 2";
            // 
            // lbPassenger2
            // 
            this.lbPassenger2.AutoSize = true;
            this.lbPassenger2.Location = new System.Drawing.Point(130, 93);
            this.lbPassenger2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassenger2.Name = "lbPassenger2";
            this.lbPassenger2.Size = new System.Drawing.Size(16, 17);
            this.lbPassenger2.TabIndex = 7;
            this.lbPassenger2.Text = "0";
            // 
            // lbCheckIn2
            // 
            this.lbCheckIn2.AutoSize = true;
            this.lbCheckIn2.Location = new System.Drawing.Point(130, 62);
            this.lbCheckIn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheckIn2.Name = "lbCheckIn2";
            this.lbCheckIn2.Size = new System.Drawing.Size(16, 17);
            this.lbCheckIn2.TabIndex = 6;
            this.lbCheckIn2.Text = "0";
            // 
            // lbBags2
            // 
            this.lbBags2.AutoSize = true;
            this.lbBags2.Location = new System.Drawing.Point(130, 31);
            this.lbBags2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBags2.Name = "lbBags2";
            this.lbBags2.Size = new System.Drawing.Size(16, 17);
            this.lbBags2.TabIndex = 5;
            this.lbBags2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bags Arrived";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Check In/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 93);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
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
            this.gbDropoff1.Location = new System.Drawing.Point(14, 37);
            this.gbDropoff1.Margin = new System.Windows.Forms.Padding(2);
            this.gbDropoff1.Name = "gbDropoff1";
            this.gbDropoff1.Padding = new System.Windows.Forms.Padding(2);
            this.gbDropoff1.Size = new System.Drawing.Size(228, 120);
            this.gbDropoff1.TabIndex = 4;
            this.gbDropoff1.TabStop = false;
            this.gbDropoff1.Text = "Dropoff 1";
            // 
            // lbPassenger
            // 
            this.lbPassenger.AutoSize = true;
            this.lbPassenger.Location = new System.Drawing.Point(130, 93);
            this.lbPassenger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassenger.Name = "lbPassenger";
            this.lbPassenger.Size = new System.Drawing.Size(16, 17);
            this.lbPassenger.TabIndex = 7;
            this.lbPassenger.Text = "0";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Location = new System.Drawing.Point(130, 62);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(16, 17);
            this.lbCheckIn.TabIndex = 6;
            this.lbCheckIn.Text = "0";
            // 
            // lbBags
            // 
            this.lbBags.AutoSize = true;
            this.lbBags.Location = new System.Drawing.Point(130, 31);
            this.lbBags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBags.Name = "lbBags";
            this.lbBags.Size = new System.Drawing.Size(16, 17);
            this.lbBags.TabIndex = 5;
            this.lbBags.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bags Arrived";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Check In/s";
            // 
            // Passengers
            // 
            this.Passengers.AutoSize = true;
            this.Passengers.Location = new System.Drawing.Point(4, 93);
            this.Passengers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(83, 17);
            this.Passengers.TabIndex = 2;
            this.Passengers.Text = "Passengers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 27;
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.Blue;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnBreak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBreak.Location = new System.Drawing.Point(12, 319);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(163, 29);
            this.btnBreak.TabIndex = 28;
            this.btnBreak.Text = "Break/Release Conveyors";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBaggy);
            this.groupBox2.Controls.Add(this.lbBagId);
            this.groupBox2.Controls.Add(this.lbDropOffDes);
            this.groupBox2.Controls.Add(this.lbTicketId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(966, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(263, 194);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Bag";
            // 
            // lbBaggy
            // 
            this.lbBaggy.AutoSize = true;
            this.lbBaggy.Location = new System.Drawing.Point(12, 159);
            this.lbBaggy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBaggy.Name = "lbBaggy";
            this.lbBaggy.Size = new System.Drawing.Size(110, 13);
            this.lbBaggy.TabIndex = 6;
            this.lbBaggy.Text = "Destanation Drop Off:";
            // 
            // lbBagId
            // 
            this.lbBagId.AutoSize = true;
            this.lbBagId.Location = new System.Drawing.Point(136, 53);
            this.lbBagId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBagId.Name = "lbBagId";
            this.lbBagId.Size = new System.Drawing.Size(56, 13);
            this.lbBagId.TabIndex = 5;
            this.lbBagId.Text = "SelectBag";
            // 
            // lbDropOffDes
            // 
            this.lbDropOffDes.AutoSize = true;
            this.lbDropOffDes.Location = new System.Drawing.Point(136, 125);
            this.lbDropOffDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDropOffDes.Name = "lbDropOffDes";
            this.lbDropOffDes.Size = new System.Drawing.Size(56, 13);
            this.lbDropOffDes.TabIndex = 4;
            this.lbDropOffDes.Text = "SelectBag";
            // 
            // lbTicketId
            // 
            this.lbTicketId.AutoSize = true;
            this.lbTicketId.Location = new System.Drawing.Point(136, 89);
            this.lbTicketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTicketId.Name = "lbTicketId";
            this.lbTicketId.Size = new System.Drawing.Size(56, 13);
            this.lbTicketId.TabIndex = 3;
            this.lbTicketId.Text = "SelectBag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Destanation Drop Off:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Passenger Ticket ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bag Id:";
            // 
            // drop1NewCheck
            // 
            this.drop1NewCheck.Interval = 2000;
            this.drop1NewCheck.Tick += new System.EventHandler(this.drop1NewCheck_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(517, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "CHECK IN3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(677, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "CHECK IN4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(517, 492);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "DROP OFF2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(197, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "DROP OFF1";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(357, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "DROP OFF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(517, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "DROP OFF1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(677, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "DROP OFF";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox1.Location = new System.Drawing.Point(114, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "dropoff";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox2.Location = new System.Drawing.Point(279, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(61, 21);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.Text = "dropoff";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox3.Location = new System.Drawing.Point(440, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(61, 21);
            this.comboBox3.TabIndex = 43;
            this.comboBox3.Text = "dropoff";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "dropoff1",
            "dropoff2",
            "dropoff3"});
            this.comboBox4.Location = new System.Drawing.Point(599, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(61, 21);
            this.comboBox4.TabIndex = 44;
            this.comboBox4.Text = "dropoff";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(677, 492);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "DROP OFF1";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
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
        private System.Windows.Forms.Timer CheckIn1;
        private System.Windows.Forms.Timer CheckIn2;
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
        private System.Windows.Forms.Label lbDropOffDes;
        private System.Windows.Forms.Label lbTicketId;
        private System.Windows.Forms.Label lbBaggy;
        private System.Windows.Forms.Timer drop1NewCheck;
        private System.Windows.Forms.Label lbBagId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label19;
    }
}

