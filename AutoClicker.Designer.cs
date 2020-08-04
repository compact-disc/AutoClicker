namespace AutoClicker
{
    partial class AutoClicker
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClickTypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MouseButtonBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetPositionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActivePosRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SetPosRadio = new System.Windows.Forms.RadioButton();
            this.YPos = new System.Windows.Forms.TextBox();
            this.XPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinutesBox = new System.Windows.Forms.TextBox();
            this.SecondsBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MillisecondsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SliderRadio = new System.Windows.Forms.RadioButton();
            this.ManualRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HoursBox = new System.Windows.Forms.TextBox();
            this.SliderSpeedValue = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 363);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(375, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start [F6]";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartAutoClicker);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(417, 363);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(180, 50);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop [F6]";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopAutoClicker);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClickTypeBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MouseButtonBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Options";
            // 
            // ClickTypeBox
            // 
            this.ClickTypeBox.FormattingEnabled = true;
            this.ClickTypeBox.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.ClickTypeBox.Location = new System.Drawing.Point(127, 86);
            this.ClickTypeBox.Name = "ClickTypeBox";
            this.ClickTypeBox.Size = new System.Drawing.Size(121, 24);
            this.ClickTypeBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Click Type";
            // 
            // MouseButtonBox
            // 
            this.MouseButtonBox.FormattingEnabled = true;
            this.MouseButtonBox.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.MouseButtonBox.Location = new System.Drawing.Point(127, 35);
            this.MouseButtonBox.Name = "MouseButtonBox";
            this.MouseButtonBox.Size = new System.Drawing.Size(121, 24);
            this.MouseButtonBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mouse Button";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetPositionLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ActivePosRadio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SetPosRadio);
            this.groupBox2.Controls.Add(this.YPos);
            this.groupBox2.Controls.Add(this.XPos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse Position";
            // 
            // SetPositionLabel
            // 
            this.SetPositionLabel.AutoSize = true;
            this.SetPositionLabel.Location = new System.Drawing.Point(112, 130);
            this.SetPositionLabel.Name = "SetPositionLabel";
            this.SetPositionLabel.Size = new System.Drawing.Size(183, 17);
            this.SetPositionLabel.TabIndex = 6;
            this.SetPositionLabel.Text = "[F7] To Set Current Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // ActivePosRadio
            // 
            this.ActivePosRadio.AutoSize = true;
            this.ActivePosRadio.Location = new System.Drawing.Point(49, 38);
            this.ActivePosRadio.Name = "ActivePosRadio";
            this.ActivePosRadio.Size = new System.Drawing.Size(64, 21);
            this.ActivePosRadio.TabIndex = 0;
            this.ActivePosRadio.TabStop = true;
            this.ActivePosRadio.Text = "Active";
            this.ActivePosRadio.UseVisualStyleBackColor = true;
            this.ActivePosRadio.Click += new System.EventHandler(this.SetActiveRadioSelector);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // SetPosRadio
            // 
            this.SetPosRadio.AutoSize = true;
            this.SetPosRadio.Location = new System.Drawing.Point(49, 75);
            this.SetPosRadio.Name = "SetPosRadio";
            this.SetPosRadio.Size = new System.Drawing.Size(101, 21);
            this.SetPosRadio.TabIndex = 1;
            this.SetPosRadio.TabStop = true;
            this.SetPosRadio.Text = "Set Position";
            this.SetPosRadio.UseVisualStyleBackColor = true;
            this.SetPosRadio.Click += new System.EventHandler(this.SetPositionRadioSelector);
            // 
            // YPos
            // 
            this.YPos.Location = new System.Drawing.Point(218, 104);
            this.YPos.Name = "YPos";
            this.YPos.Size = new System.Drawing.Size(100, 23);
            this.YPos.TabIndex = 3;
            this.YPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // XPos
            // 
            this.XPos.Location = new System.Drawing.Point(76, 104);
            this.XPos.Name = "XPos";
            this.XPos.Size = new System.Drawing.Size(100, 23);
            this.XPos.TabIndex = 2;
            this.XPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Auto Clicker";
            // 
            // MinutesBox
            // 
            this.MinutesBox.Location = new System.Drawing.Point(196, 22);
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(100, 23);
            this.MinutesBox.TabIndex = 1;
            this.MinutesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // SecondsBox
            // 
            this.SecondsBox.Location = new System.Drawing.Point(365, 22);
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(100, 23);
            this.SecondsBox.TabIndex = 2;
            this.SecondsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Seconds";
            // 
            // MillisecondsBox
            // 
            this.MillisecondsBox.Location = new System.Drawing.Point(540, 22);
            this.MillisecondsBox.Name = "MillisecondsBox";
            this.MillisecondsBox.Size = new System.Drawing.Size(100, 23);
            this.MillisecondsBox.TabIndex = 6;
            this.MillisecondsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Milliseconds";
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Location = new System.Drawing.Point(38, 94);
            this.SpeedSlider.Maximum = 20;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(602, 45);
            this.SpeedSlider.TabIndex = 8;
            this.SpeedSlider.Scroll += new System.EventHandler(this.SliderScroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Slider Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(686, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(696, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Milliseconds";
            // 
            // SliderRadio
            // 
            this.SliderRadio.AutoSize = true;
            this.SliderRadio.Location = new System.Drawing.Point(283, 67);
            this.SliderRadio.Name = "SliderRadio";
            this.SliderRadio.Size = new System.Drawing.Size(62, 21);
            this.SliderRadio.TabIndex = 13;
            this.SliderRadio.TabStop = true;
            this.SliderRadio.Text = "Slider";
            this.SliderRadio.UseVisualStyleBackColor = true;
            this.SliderRadio.Click += new System.EventHandler(this.SetSliderRadioButton);
            // 
            // ManualRadio
            // 
            this.ManualRadio.AutoSize = true;
            this.ManualRadio.Location = new System.Drawing.Point(388, 67);
            this.ManualRadio.Name = "ManualRadio";
            this.ManualRadio.Size = new System.Drawing.Size(109, 21);
            this.ManualRadio.TabIndex = 14;
            this.ManualRadio.TabStop = true;
            this.ManualRadio.Text = "Manual Entry";
            this.ManualRadio.UseVisualStyleBackColor = true;
            this.ManualRadio.Click += new System.EventHandler(this.SetManualEntryRadioSelector);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HoursBox);
            this.groupBox3.Controls.Add(this.SliderSpeedValue);
            this.groupBox3.Controls.Add(this.ManualRadio);
            this.groupBox3.Controls.Add(this.SliderRadio);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.SpeedSlider);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.MillisecondsBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.SecondsBox);
            this.groupBox3.Controls.Add(this.MinutesBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 145);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Between Clicks";
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(38, 22);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(100, 23);
            this.HoursBox.TabIndex = 16;
            this.HoursBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValidation);
            // 
            // SliderSpeedValue
            // 
            this.SliderSpeedValue.AutoSize = true;
            this.SliderSpeedValue.Location = new System.Drawing.Point(646, 112);
            this.SliderSpeedValue.Name = "SliderSpeedValue";
            this.SliderSpeedValue.Size = new System.Drawing.Size(16, 17);
            this.SliderSpeedValue.TabIndex = 15;
            this.SliderSpeedValue.Text = "0";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(612, 363);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(180, 50);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear Entries";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearEntryBoxes);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 425);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoClickerFormClose);
            this.Load += new System.EventHandler(this.AutoClickerFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeys);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ClickTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MouseButtonBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ActivePosRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SetPosRadio;
        private System.Windows.Forms.TextBox YPos;
        private System.Windows.Forms.TextBox XPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinutesBox;
        private System.Windows.Forms.TextBox SecondsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MillisecondsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar SpeedSlider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton SliderRadio;
        private System.Windows.Forms.RadioButton ManualRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.Label SliderSpeedValue;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label SetPositionLabel;
    }
}

