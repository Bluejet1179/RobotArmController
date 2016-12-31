namespace RobotArmControllerV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pot1 = new System.Windows.Forms.TextBox();
            this.pot2 = new System.Windows.Forms.TextBox();
            this.pot3 = new System.Windows.Forms.TextBox();
            this.pot4 = new System.Windows.Forms.TextBox();
            this.pot5 = new System.Windows.Forms.TextBox();
            this.pot6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.stopTimerButton = new System.Windows.Forms.Button();
            this.resetTimerButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pot1
            // 
            this.pot1.BackColor = System.Drawing.SystemColors.Window;
            this.pot1.Enabled = false;
            this.pot1.Location = new System.Drawing.Point(219, 72);
            this.pot1.Name = "pot1";
            this.pot1.ReadOnly = true;
            this.pot1.Size = new System.Drawing.Size(100, 26);
            this.pot1.TabIndex = 0;
            this.pot1.TextChanged += new System.EventHandler(this.pot1_TextChanged);
            // 
            // pot2
            // 
            this.pot2.BackColor = System.Drawing.SystemColors.Window;
            this.pot2.Enabled = false;
            this.pot2.Location = new System.Drawing.Point(325, 72);
            this.pot2.Name = "pot2";
            this.pot2.ReadOnly = true;
            this.pot2.Size = new System.Drawing.Size(100, 26);
            this.pot2.TabIndex = 1;
            // 
            // pot3
            // 
            this.pot3.BackColor = System.Drawing.SystemColors.Window;
            this.pot3.Enabled = false;
            this.pot3.Location = new System.Drawing.Point(431, 72);
            this.pot3.Name = "pot3";
            this.pot3.ReadOnly = true;
            this.pot3.Size = new System.Drawing.Size(100, 26);
            this.pot3.TabIndex = 2;
            // 
            // pot4
            // 
            this.pot4.BackColor = System.Drawing.SystemColors.Window;
            this.pot4.Enabled = false;
            this.pot4.Location = new System.Drawing.Point(538, 71);
            this.pot4.Name = "pot4";
            this.pot4.ReadOnly = true;
            this.pot4.Size = new System.Drawing.Size(100, 26);
            this.pot4.TabIndex = 3;
            // 
            // pot5
            // 
            this.pot5.BackColor = System.Drawing.SystemColors.Window;
            this.pot5.Enabled = false;
            this.pot5.Location = new System.Drawing.Point(645, 71);
            this.pot5.Name = "pot5";
            this.pot5.ReadOnly = true;
            this.pot5.Size = new System.Drawing.Size(100, 26);
            this.pot5.TabIndex = 4;
            // 
            // pot6
            // 
            this.pot6.BackColor = System.Drawing.SystemColors.Window;
            this.pot6.Enabled = false;
            this.pot6.Location = new System.Drawing.Point(752, 71);
            this.pot6.Name = "pot6";
            this.pot6.ReadOnly = true;
            this.pot6.Size = new System.Drawing.Size(100, 26);
            this.pot6.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudRateComboBox);
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM Port";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(6, 121);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 28);
            this.baudRateComboBox.TabIndex = 7;
            this.baudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.baudRateComboBox_SelectedIndexChanged);
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(6, 54);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 28);
            this.portComboBox.TabIndex = 7;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged_1);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDisconnect.Location = new System.Drawing.Point(7, 162);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(104, 32);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonConnect.Location = new System.Drawing.Point(6, 162);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(95, 32);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turntable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Joint 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Joint 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Joint 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Joint 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Joint 6";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(191, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 114);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servo Positions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(706, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Designed by Ryan Flora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Enabled = false;
            this.timerTextBox.ForeColor = System.Drawing.Color.Black;
            this.timerTextBox.Location = new System.Drawing.Point(205, 174);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(100, 26);
            this.timerTextBox.TabIndex = 15;
            // 
            // startTimerButton
            // 
            this.startTimerButton.Location = new System.Drawing.Point(311, 172);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(82, 31);
            this.startTimerButton.TabIndex = 16;
            this.startTimerButton.Text = "Start";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // stopTimerButton
            // 
            this.stopTimerButton.Location = new System.Drawing.Point(400, 172);
            this.stopTimerButton.Name = "stopTimerButton";
            this.stopTimerButton.Size = new System.Drawing.Size(89, 31);
            this.stopTimerButton.TabIndex = 17;
            this.stopTimerButton.Text = "Stop";
            this.stopTimerButton.UseVisualStyleBackColor = true;
            this.stopTimerButton.Click += new System.EventHandler(this.stopTimerButton_Click);
            // 
            // resetTimerButton
            // 
            this.resetTimerButton.Location = new System.Drawing.Point(495, 172);
            this.resetTimerButton.Name = "resetTimerButton";
            this.resetTimerButton.Size = new System.Drawing.Size(85, 31);
            this.resetTimerButton.TabIndex = 18;
            this.resetTimerButton.Text = "Reset";
            this.resetTimerButton.UseVisualStyleBackColor = true;
            this.resetTimerButton.Click += new System.EventHandler(this.resetTimerButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(192, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 63);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(902, 232);
            this.Controls.Add(this.resetTimerButton);
            this.Controls.Add(this.stopTimerButton);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pot6);
            this.Controls.Add(this.pot5);
            this.Controls.Add(this.pot4);
            this.Controls.Add(this.pot3);
            this.Controls.Add(this.pot2);
            this.Controls.Add(this.pot1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Robot Arm Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pot1;
        private System.Windows.Forms.TextBox pot2;
        private System.Windows.Forms.TextBox pot3;
        private System.Windows.Forms.TextBox pot4;
        private System.Windows.Forms.TextBox pot5;
        private System.Windows.Forms.TextBox pot6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        public System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.Button stopTimerButton;
        private System.Windows.Forms.Button resetTimerButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

