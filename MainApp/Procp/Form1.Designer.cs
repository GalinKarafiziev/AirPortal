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
            this.CloseCheckIn = new System.Windows.Forms.Button();
            this.labelDrop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBagsCounterD1 = new System.Windows.Forms.Label();
            this.lbBagsCounterD2 = new System.Windows.Forms.Label();
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
            // btnCheckIn2
            // 
            this.btnCheckIn2.BackColor = System.Drawing.Color.Blue;
            this.btnCheckIn2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCheckIn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckIn2.Location = new System.Drawing.Point(5, 277);
            this.btnCheckIn2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn2.Name = "btnCheckIn2";
            this.btnCheckIn2.Size = new System.Drawing.Size(103, 49);
            this.btnCheckIn2.TabIndex = 12;
            this.btnCheckIn2.Text = "Open check in 2";
            this.btnCheckIn2.UseVisualStyleBackColor = false;
            this.btnCheckIn2.Click += new System.EventHandler(this.btnCheckIn2_Click);
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
            // lbBagsCounterD1
            // 
            this.lbBagsCounterD1.AutoSize = true;
            this.lbBagsCounterD1.Location = new System.Drawing.Point(194, 645);
            this.lbBagsCounterD1.Name = "lbBagsCounterD1";
            this.lbBagsCounterD1.Size = new System.Drawing.Size(119, 17);
            this.lbBagsCounterD1.TabIndex = 24;
            this.lbBagsCounterD1.Text = "lbBagsCounterD1";
            // 
            // lbBagsCounterD2
            // 
            this.lbBagsCounterD2.AutoSize = true;
            this.lbBagsCounterD2.Location = new System.Drawing.Point(885, 624);
            this.lbBagsCounterD2.Name = "lbBagsCounterD2";
            this.lbBagsCounterD2.Size = new System.Drawing.Size(119, 17);
            this.lbBagsCounterD2.TabIndex = 25;
            this.lbBagsCounterD2.Text = "lbBagsCounterD2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 666);
            this.Controls.Add(this.lbBagsCounterD2);
            this.Controls.Add(this.lbBagsCounterD1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDrop);
            this.Controls.Add(this.CloseCheckIn);
            this.Controls.Add(this.btnCheckIn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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
        private System.Windows.Forms.Button CloseCheckIn;
        private System.Windows.Forms.Label labelDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBagsCounterD1;
        private System.Windows.Forms.Label lbBagsCounterD2;
    }
}

