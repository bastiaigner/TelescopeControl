namespace TelescopeControl
{
    partial class FocuserForm
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
            components = new System.ComponentModel.Container();
            textBox_focusPosition = new System.Windows.Forms.TextBox();
            trackBar_position = new System.Windows.Forms.TrackBar();
            label_min = new System.Windows.Forms.Label();
            label_max = new System.Windows.Forms.Label();
            timer_refreshUI = new System.Windows.Forms.Timer(components);
            button_halt = new System.Windows.Forms.Button();
            label_currTemp = new System.Windows.Forms.Label();
            textBox_compRate = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkBox_calibrateOnMove = new System.Windows.Forms.CheckBox();
            button_calibrateNow = new System.Windows.Forms.Button();
            label_lastCompensation = new System.Windows.Forms.Label();
            label_origPosition = new System.Windows.Forms.Label();
            label_deltaTemp = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button_RunCompenationNow = new System.Windows.Forms.Button();
            checkBox_continuosCompensation = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            checkBox_enabled = new System.Windows.Forms.CheckBox();
            label_homingStatus = new System.Windows.Forms.Label();
            button_homeServo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)trackBar_position).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_focusPosition
            // 
            textBox_focusPosition.Enabled = false;
            textBox_focusPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_focusPosition.Location = new System.Drawing.Point(296, 96);
            textBox_focusPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_focusPosition.Name = "textBox_focusPosition";
            textBox_focusPosition.ReadOnly = true;
            textBox_focusPosition.Size = new System.Drawing.Size(270, 74);
            textBox_focusPosition.TabIndex = 0;
            textBox_focusPosition.Text = "12.34";
            textBox_focusPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar_position
            // 
            trackBar_position.Location = new System.Drawing.Point(13, 38);
            trackBar_position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackBar_position.Name = "trackBar_position";
            trackBar_position.Size = new System.Drawing.Size(841, 90);
            trackBar_position.TabIndex = 1;
            trackBar_position.Scroll += trackBar_position_Scroll;
            // 
            // label_min
            // 
            label_min.AutoSize = true;
            label_min.Location = new System.Drawing.Point(13, 96);
            label_min.Name = "label_min";
            label_min.Size = new System.Drawing.Size(107, 32);
            label_min.TabIndex = 2;
            label_min.Text = "0.00 mm";
            // 
            // label_max
            // 
            label_max.AutoSize = true;
            label_max.Location = new System.Drawing.Point(734, 96);
            label_max.Name = "label_max";
            label_max.Size = new System.Drawing.Size(120, 32);
            label_max.TabIndex = 3;
            label_max.Text = "30.00 mm";
            label_max.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer_refreshUI
            // 
            timer_refreshUI.Tick += timer_refreshUI_Tick;
            // 
            // button_halt
            // 
            button_halt.BackColor = System.Drawing.Color.Red;
            button_halt.Location = new System.Drawing.Point(23, 252);
            button_halt.Name = "button_halt";
            button_halt.Size = new System.Drawing.Size(182, 154);
            button_halt.TabIndex = 4;
            button_halt.Text = "Halt";
            button_halt.UseVisualStyleBackColor = false;
            button_halt.Click += button_halt_Click;
            // 
            // label_currTemp
            // 
            label_currTemp.AutoSize = true;
            label_currTemp.Location = new System.Drawing.Point(467, 131);
            label_currTemp.Name = "label_currTemp";
            label_currTemp.Size = new System.Drawing.Size(93, 32);
            label_currTemp.TabIndex = 5;
            label_currTemp.Text = "12.34 C";
            label_currTemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_compRate
            // 
            textBox_compRate.Location = new System.Drawing.Point(360, 71);
            textBox_compRate.Name = "textBox_compRate";
            textBox_compRate.Size = new System.Drawing.Size(200, 39);
            textBox_compRate.TabIndex = 6;
            textBox_compRate.TextChanged += textBox_compRate_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_calibrateOnMove);
            groupBox1.Controls.Add(button_calibrateNow);
            groupBox1.Controls.Add(label_lastCompensation);
            groupBox1.Controls.Add(label_origPosition);
            groupBox1.Controls.Add(label_deltaTemp);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button_RunCompenationNow);
            groupBox1.Controls.Add(checkBox_continuosCompensation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label_currTemp);
            groupBox1.Controls.Add(textBox_compRate);
            groupBox1.Location = new System.Drawing.Point(259, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(576, 562);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperature Compensation";
            // 
            // checkBox_calibrateOnMove
            // 
            checkBox_calibrateOnMove.AutoSize = true;
            checkBox_calibrateOnMove.Location = new System.Drawing.Point(34, 318);
            checkBox_calibrateOnMove.Name = "checkBox_calibrateOnMove";
            checkBox_calibrateOnMove.Size = new System.Drawing.Size(243, 36);
            checkBox_calibrateOnMove.TabIndex = 18;
            checkBox_calibrateOnMove.Text = "Calibrate on Move";
            checkBox_calibrateOnMove.UseVisualStyleBackColor = true;
            checkBox_calibrateOnMove.CheckedChanged += checkBox_calibrateOnMove_CheckedChanged;
            // 
            // button_calibrateNow
            // 
            button_calibrateNow.Location = new System.Drawing.Point(346, 311);
            button_calibrateNow.Name = "button_calibrateNow";
            button_calibrateNow.Size = new System.Drawing.Size(214, 49);
            button_calibrateNow.TabIndex = 17;
            button_calibrateNow.Text = "Calibrate Now";
            button_calibrateNow.UseVisualStyleBackColor = true;
            button_calibrateNow.Click += button_calibrateNow_Click;
            // 
            // label_lastCompensation
            // 
            label_lastCompensation.AutoSize = true;
            label_lastCompensation.Location = new System.Drawing.Point(489, 505);
            label_lastCompensation.Name = "label_lastCompensation";
            label_lastCompensation.Size = new System.Drawing.Size(71, 32);
            label_lastCompensation.TabIndex = 16;
            label_lastCompensation.Text = "21:32";
            label_lastCompensation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_origPosition
            // 
            label_origPosition.AutoSize = true;
            label_origPosition.Location = new System.Drawing.Point(467, 252);
            label_origPosition.Name = "label_origPosition";
            label_origPosition.Size = new System.Drawing.Size(93, 32);
            label_origPosition.TabIndex = 15;
            label_origPosition.Text = "12.34 C";
            label_origPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_deltaTemp
            // 
            label_deltaTemp.AutoSize = true;
            label_deltaTemp.Location = new System.Drawing.Point(467, 190);
            label_deltaTemp.Name = "label_deltaTemp";
            label_deltaTemp.Size = new System.Drawing.Size(93, 32);
            label_deltaTemp.TabIndex = 14;
            label_deltaTemp.Text = "12.34 C";
            label_deltaTemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 505);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(213, 32);
            label5.TabIndex = 13;
            label5.Text = "Last compensation";
            // 
            // button_RunCompenationNow
            // 
            button_RunCompenationNow.Location = new System.Drawing.Point(346, 438);
            button_RunCompenationNow.Name = "button_RunCompenationNow";
            button_RunCompenationNow.Size = new System.Drawing.Size(214, 49);
            button_RunCompenationNow.TabIndex = 12;
            button_RunCompenationNow.Text = "Compensate Now";
            button_RunCompenationNow.UseVisualStyleBackColor = true;
            button_RunCompenationNow.Click += button_RunCompenationNow_Click;
            // 
            // checkBox_continuosCompensation
            // 
            checkBox_continuosCompensation.AutoSize = true;
            checkBox_continuosCompensation.Location = new System.Drawing.Point(34, 444);
            checkBox_continuosCompensation.Name = "checkBox_continuosCompensation";
            checkBox_continuosCompensation.Size = new System.Drawing.Size(178, 36);
            checkBox_continuosCompensation.TabIndex = 11;
            checkBox_continuosCompensation.Text = "Cont. Comp.";
            checkBox_continuosCompensation.UseVisualStyleBackColor = true;
            checkBox_continuosCompensation.CheckedChanged += checkBox_continuosCompensation_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 252);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(189, 32);
            label4.TabIndex = 10;
            label4.Text = "Original Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(212, 32);
            label3.TabIndex = 9;
            label3.Text = "Delta Temperature";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(236, 32);
            label2.TabIndex = 8;
            label2.Text = "Current Temperature";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 32);
            label1.TabIndex = 7;
            label1.Text = "mm / degC";
            // 
            // checkBox_enabled
            // 
            checkBox_enabled.AutoSize = true;
            checkBox_enabled.Location = new System.Drawing.Point(30, 204);
            checkBox_enabled.Name = "checkBox_enabled";
            checkBox_enabled.Size = new System.Drawing.Size(131, 36);
            checkBox_enabled.TabIndex = 8;
            checkBox_enabled.Text = "Enabled";
            checkBox_enabled.UseVisualStyleBackColor = true;
            checkBox_enabled.CheckedChanged += checkBox_enabled_CheckedChanged;
            // 
            // label_homingStatus
            // 
            label_homingStatus.AutoSize = true;
            label_homingStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label_homingStatus.Location = new System.Drawing.Point(30, 526);
            label_homingStatus.Name = "label_homingStatus";
            label_homingStatus.Size = new System.Drawing.Size(192, 32);
            label_homingStatus.TabIndex = 9;
            label_homingStatus.Text = "Needs Homing!";
            // 
            // button_homeServo
            // 
            button_homeServo.Location = new System.Drawing.Point(30, 572);
            button_homeServo.Name = "button_homeServo";
            button_homeServo.Size = new System.Drawing.Size(175, 46);
            button_homeServo.TabIndex = 10;
            button_homeServo.Text = "Home Servo";
            button_homeServo.UseVisualStyleBackColor = true;
            button_homeServo.Click += button_homeServo_Click;
            // 
            // FocuserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(867, 800);
            Controls.Add(button_homeServo);
            Controls.Add(label_homingStatus);
            Controls.Add(checkBox_enabled);
            Controls.Add(groupBox1);
            Controls.Add(textBox_focusPosition);
            Controls.Add(button_halt);
            Controls.Add(label_max);
            Controls.Add(label_min);
            Controls.Add(trackBar_position);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FocuserForm";
            Text = "FocuserForm";
            ((System.ComponentModel.ISupportInitialize)trackBar_position).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_focusPosition;
        private System.Windows.Forms.TrackBar trackBar_position;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Timer timer_refreshUI;
        private System.Windows.Forms.Button button_halt;
        private System.Windows.Forms.Label label_currTemp;
        private System.Windows.Forms.TextBox textBox_compRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_continuosCompensation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_origPosition;
        private System.Windows.Forms.Label label_deltaTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_RunCompenationNow;
        private System.Windows.Forms.Label label_lastCompensation;
        private System.Windows.Forms.Button button_calibrateNow;
        private System.Windows.Forms.CheckBox checkBox_calibrateOnMove;
        private System.Windows.Forms.CheckBox checkBox_enabled;
        private System.Windows.Forms.Label label_homingStatus;
        private System.Windows.Forms.Button button_homeServo;
    }
}