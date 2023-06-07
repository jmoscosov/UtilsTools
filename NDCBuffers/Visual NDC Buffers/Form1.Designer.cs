
namespace Visual_NDC_Buffers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dispensed4 = new System.Windows.Forms.TextBox();
            this.txt_dispensed3 = new System.Windows.Forms.TextBox();
            this.txt_dispensed1 = new System.Windows.Forms.TextBox();
            this.txt_dispensed2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_remaining4 = new System.Windows.Forms.TextBox();
            this.txt_remaining3 = new System.Windows.Forms.TextBox();
            this.txt_remaining1 = new System.Windows.Forms.TextBox();
            this.txt_remaining2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rejected4 = new System.Windows.Forms.TextBox();
            this.txt_rejected3 = new System.Windows.Forms.TextBox();
            this.txt_rejected1 = new System.Windows.Forms.TextBox();
            this.txt_rejected2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cassette4 = new System.Windows.Forms.TextBox();
            this.txt_cassette3 = new System.Windows.Forms.TextBox();
            this.txt_cassette1 = new System.Windows.Forms.TextBox();
            this.txt_cassette2 = new System.Windows.Forms.TextBox();
            this.btnUpdateCounters = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_getData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getData);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATM INFO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 585);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buffers";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Update";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(16, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 263);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Counters";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateCounters);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_dispensed4);
            this.groupBox3.Controls.Add(this.txt_dispensed3);
            this.groupBox3.Controls.Add(this.txt_dispensed1);
            this.groupBox3.Controls.Add(this.txt_dispensed2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_remaining4);
            this.groupBox3.Controls.Add(this.txt_remaining3);
            this.groupBox3.Controls.Add(this.txt_remaining1);
            this.groupBox3.Controls.Add(this.txt_remaining2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_rejected4);
            this.groupBox3.Controls.Add(this.txt_rejected3);
            this.groupBox3.Controls.Add(this.txt_rejected1);
            this.groupBox3.Controls.Add(this.txt_rejected2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_cassette4);
            this.groupBox3.Controls.Add(this.txt_cassette3);
            this.groupBox3.Controls.Add(this.txt_cassette1);
            this.groupBox3.Controls.Add(this.txt_cassette2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Values";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "DISPENSED";
            // 
            // txt_dispensed4
            // 
            this.txt_dispensed4.Location = new System.Drawing.Point(480, 149);
            this.txt_dispensed4.Name = "txt_dispensed4";
            this.txt_dispensed4.Size = new System.Drawing.Size(100, 22);
            this.txt_dispensed4.TabIndex = 22;
            // 
            // txt_dispensed3
            // 
            this.txt_dispensed3.Location = new System.Drawing.Point(355, 149);
            this.txt_dispensed3.Name = "txt_dispensed3";
            this.txt_dispensed3.Size = new System.Drawing.Size(100, 22);
            this.txt_dispensed3.TabIndex = 21;
            // 
            // txt_dispensed1
            // 
            this.txt_dispensed1.Location = new System.Drawing.Point(97, 149);
            this.txt_dispensed1.Name = "txt_dispensed1";
            this.txt_dispensed1.Size = new System.Drawing.Size(100, 22);
            this.txt_dispensed1.TabIndex = 19;
            // 
            // txt_dispensed2
            // 
            this.txt_dispensed2.Location = new System.Drawing.Point(227, 149);
            this.txt_dispensed2.Name = "txt_dispensed2";
            this.txt_dispensed2.Size = new System.Drawing.Size(100, 22);
            this.txt_dispensed2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "REMAINING";
            // 
            // txt_remaining4
            // 
            this.txt_remaining4.Location = new System.Drawing.Point(480, 112);
            this.txt_remaining4.Name = "txt_remaining4";
            this.txt_remaining4.Size = new System.Drawing.Size(100, 22);
            this.txt_remaining4.TabIndex = 17;
            // 
            // txt_remaining3
            // 
            this.txt_remaining3.Location = new System.Drawing.Point(355, 112);
            this.txt_remaining3.Name = "txt_remaining3";
            this.txt_remaining3.Size = new System.Drawing.Size(100, 22);
            this.txt_remaining3.TabIndex = 16;
            // 
            // txt_remaining1
            // 
            this.txt_remaining1.Location = new System.Drawing.Point(97, 112);
            this.txt_remaining1.Name = "txt_remaining1";
            this.txt_remaining1.Size = new System.Drawing.Size(100, 22);
            this.txt_remaining1.TabIndex = 14;
            // 
            // txt_remaining2
            // 
            this.txt_remaining2.Location = new System.Drawing.Point(227, 112);
            this.txt_remaining2.Name = "txt_remaining2";
            this.txt_remaining2.Size = new System.Drawing.Size(100, 22);
            this.txt_remaining2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "REJECTED";
            // 
            // txt_rejected4
            // 
            this.txt_rejected4.Location = new System.Drawing.Point(480, 73);
            this.txt_rejected4.Name = "txt_rejected4";
            this.txt_rejected4.Size = new System.Drawing.Size(100, 22);
            this.txt_rejected4.TabIndex = 12;
            // 
            // txt_rejected3
            // 
            this.txt_rejected3.Location = new System.Drawing.Point(355, 73);
            this.txt_rejected3.Name = "txt_rejected3";
            this.txt_rejected3.Size = new System.Drawing.Size(100, 22);
            this.txt_rejected3.TabIndex = 11;
            // 
            // txt_rejected1
            // 
            this.txt_rejected1.Location = new System.Drawing.Point(97, 73);
            this.txt_rejected1.Name = "txt_rejected1";
            this.txt_rejected1.Size = new System.Drawing.Size(100, 22);
            this.txt_rejected1.TabIndex = 9;
            // 
            // txt_rejected2
            // 
            this.txt_rejected2.Location = new System.Drawing.Point(227, 73);
            this.txt_rejected2.Name = "txt_rejected2";
            this.txt_rejected2.Size = new System.Drawing.Size(100, 22);
            this.txt_rejected2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CASSETTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type1";
            // 
            // txt_cassette4
            // 
            this.txt_cassette4.Location = new System.Drawing.Point(480, 36);
            this.txt_cassette4.Name = "txt_cassette4";
            this.txt_cassette4.Size = new System.Drawing.Size(100, 22);
            this.txt_cassette4.TabIndex = 3;
            // 
            // txt_cassette3
            // 
            this.txt_cassette3.Location = new System.Drawing.Point(355, 36);
            this.txt_cassette3.Name = "txt_cassette3";
            this.txt_cassette3.Size = new System.Drawing.Size(100, 22);
            this.txt_cassette3.TabIndex = 2;
            // 
            // txt_cassette1
            // 
            this.txt_cassette1.Location = new System.Drawing.Point(97, 36);
            this.txt_cassette1.Name = "txt_cassette1";
            this.txt_cassette1.Size = new System.Drawing.Size(100, 22);
            this.txt_cassette1.TabIndex = 0;
            // 
            // txt_cassette2
            // 
            this.txt_cassette2.Location = new System.Drawing.Point(227, 36);
            this.txt_cassette2.Name = "txt_cassette2";
            this.txt_cassette2.Size = new System.Drawing.Size(100, 22);
            this.txt_cassette2.TabIndex = 1;
            // 
            // btnUpdateCounters
            // 
            this.btnUpdateCounters.Location = new System.Drawing.Point(598, 39);
            this.btnUpdateCounters.Name = "btnUpdateCounters";
            this.btnUpdateCounters.Size = new System.Drawing.Size(98, 132);
            this.btnUpdateCounters.TabIndex = 24;
            this.btnUpdateCounters.Text = "Update";
            this.btnUpdateCounters.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(16, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 173);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Access";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(6, 50);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(711, 99);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Values";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 30);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "MAC NUMBER";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 21);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Update";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "OS System :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "AANDC Version : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "......";
            // 
            // btn_getData
            // 
            this.btn_getData.Location = new System.Drawing.Point(654, 21);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(112, 65);
            this.btn_getData.TabIndex = 4;
            this.btn_getData.Text = "Get Data";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateCounters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dispensed4;
        private System.Windows.Forms.TextBox txt_dispensed3;
        private System.Windows.Forms.TextBox txt_dispensed1;
        private System.Windows.Forms.TextBox txt_dispensed2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_remaining4;
        private System.Windows.Forms.TextBox txt_remaining3;
        private System.Windows.Forms.TextBox txt_remaining1;
        private System.Windows.Forms.TextBox txt_remaining2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rejected4;
        private System.Windows.Forms.TextBox txt_rejected3;
        private System.Windows.Forms.TextBox txt_rejected1;
        private System.Windows.Forms.TextBox txt_rejected2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cassette4;
        private System.Windows.Forms.TextBox txt_cassette3;
        private System.Windows.Forms.TextBox txt_cassette1;
        private System.Windows.Forms.TextBox txt_cassette2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

