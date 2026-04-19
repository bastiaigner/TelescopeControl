namespace TelescopeControl
{
    partial class MainForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox_envtemp = new System.Windows.Forms.TextBox();
            textBox_envhum = new System.Windows.Forms.TextBox();
            textBox_m1celltemp = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox_m1temp = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            groupBox = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBox_coverState = new System.Windows.Forms.ComboBox();
            button_closecovers = new System.Windows.Forms.Button();
            button_opencovers = new System.Windows.Forms.Button();
            timer_refresh = new System.Windows.Forms.Timer(components);
            groupBox2 = new System.Windows.Forms.GroupBox();
            button_primFocus = new System.Windows.Forms.Button();
            button_cassFocus = new System.Windows.Forms.Button();
            label_trussTempTL = new System.Windows.Forms.Label();
            textBox_trussTempTL = new System.Windows.Forms.TextBox();
            label_trussTempBR = new System.Windows.Forms.Label();
            textBox_trussTempBR = new System.Windows.Forms.TextBox();
            label_trussMeanTemp = new System.Windows.Forms.Label();
            textBox_trussMeanTemp = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label_haAngle = new System.Windows.Forms.Label();
            textBox_haAngle = new System.Windows.Forms.TextBox();
            label_decAngle = new System.Windows.Forms.Label();
            textBox_decAngle = new System.Windows.Forms.TextBox();
            label_altitude = new System.Windows.Forms.Label();
            textBox_altitude = new System.Windows.Forms.TextBox();
            label_azimuth = new System.Windows.Forms.Label();
            textBox_azimuth = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            trackBar_fanSpeed = new System.Windows.Forms.TrackBar();
            label_fanSpeed = new System.Windows.Forms.Label();
            label_fanSpeedValue = new System.Windows.Forms.Label();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar_fanSpeed)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(292, 32);
            label1.TabIndex = 0;
            label1.Text = "Environment Temperature";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(255, 32);
            label2.TabIndex = 1;
            label2.Text = "Environment Humidity";
            // 
            // textBox_envtemp
            // 
            textBox_envtemp.Enabled = false;
            textBox_envtemp.Location = new System.Drawing.Point(348, 51);
            textBox_envtemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_envtemp.Name = "textBox_envtemp";
            textBox_envtemp.ReadOnly = true;
            textBox_envtemp.Size = new System.Drawing.Size(143, 39);
            textBox_envtemp.TabIndex = 2;
            textBox_envtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_envhum
            // 
            textBox_envhum.Enabled = false;
            textBox_envhum.Location = new System.Drawing.Point(348, 122);
            textBox_envhum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_envhum.Name = "textBox_envhum";
            textBox_envhum.ReadOnly = true;
            textBox_envhum.Size = new System.Drawing.Size(143, 39);
            textBox_envhum.TabIndex = 3;
            textBox_envhum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_m1celltemp
            // 
            textBox_m1celltemp.Enabled = false;
            textBox_m1celltemp.Location = new System.Drawing.Point(348, 262);
            textBox_m1celltemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_m1celltemp.Name = "textBox_m1celltemp";
            textBox_m1celltemp.ReadOnly = true;
            textBox_m1celltemp.Size = new System.Drawing.Size(143, 39);
            textBox_m1celltemp.TabIndex = 7;
            textBox_m1celltemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(191, 32);
            label3.TabIndex = 5;
            label3.Text = "M1 Temperature";
            // 
            // textBox_m1temp
            // 
            textBox_m1temp.Enabled = false;
            textBox_m1temp.Location = new System.Drawing.Point(348, 192);
            textBox_m1temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_m1temp.Name = "textBox_m1temp";
            textBox_m1temp.ReadOnly = true;
            textBox_m1temp.Size = new System.Drawing.Size(143, 39);
            textBox_m1temp.TabIndex = 6;
            textBox_m1temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 266);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(238, 32);
            label4.TabIndex = 4;
            label4.Text = "M1 Cell Temperature";
            //
            // label_trussTempTL
            //
            label_trussTempTL.AutoSize = true;
            label_trussTempTL.Location = new System.Drawing.Point(28, 336);
            label_trussTempTL.Name = "label_trussTempTL";
            label_trussTempTL.Size = new System.Drawing.Size(250, 32);
            label_trussTempTL.TabIndex = 8;
            label_trussTempTL.Text = "Truss Temp Top Left";
            //
            // textBox_trussTempTL
            //
            textBox_trussTempTL.Enabled = false;
            textBox_trussTempTL.Location = new System.Drawing.Point(348, 332);
            textBox_trussTempTL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_trussTempTL.Name = "textBox_trussTempTL";
            textBox_trussTempTL.ReadOnly = true;
            textBox_trussTempTL.Size = new System.Drawing.Size(143, 39);
            textBox_trussTempTL.TabIndex = 9;
            textBox_trussTempTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label_trussTempBR
            //
            label_trussTempBR.AutoSize = true;
            label_trussTempBR.Location = new System.Drawing.Point(28, 406);
            label_trussTempBR.Name = "label_trussTempBR";
            label_trussTempBR.Size = new System.Drawing.Size(290, 32);
            label_trussTempBR.TabIndex = 10;
            label_trussTempBR.Text = "Truss Temp Bottom Right";
            //
            // textBox_trussTempBR
            //
            textBox_trussTempBR.Enabled = false;
            textBox_trussTempBR.Location = new System.Drawing.Point(348, 402);
            textBox_trussTempBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_trussTempBR.Name = "textBox_trussTempBR";
            textBox_trussTempBR.ReadOnly = true;
            textBox_trussTempBR.Size = new System.Drawing.Size(143, 39);
            textBox_trussTempBR.TabIndex = 11;
            textBox_trussTempBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label_trussMeanTemp
            //
            label_trussMeanTemp.AutoSize = true;
            label_trussMeanTemp.Location = new System.Drawing.Point(28, 476);
            label_trussMeanTemp.Name = "label_trussMeanTemp";
            label_trussMeanTemp.Size = new System.Drawing.Size(270, 32);
            label_trussMeanTemp.TabIndex = 12;
            label_trussMeanTemp.Text = "Truss Mean Temperature";
            //
            // textBox_trussMeanTemp
            //
            textBox_trussMeanTemp.Enabled = false;
            textBox_trussMeanTemp.Location = new System.Drawing.Point(348, 472);
            textBox_trussMeanTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_trussMeanTemp.Name = "textBox_trussMeanTemp";
            textBox_trussMeanTemp.ReadOnly = true;
            textBox_trussMeanTemp.Size = new System.Drawing.Size(143, 39);
            textBox_trussMeanTemp.TabIndex = 13;
            textBox_trussMeanTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // groupBox
            //
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(textBox_m1celltemp);
            groupBox.Controls.Add(textBox_envtemp);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(textBox_m1temp);
            groupBox.Controls.Add(textBox_envhum);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label_trussTempTL);
            groupBox.Controls.Add(textBox_trussTempTL);
            groupBox.Controls.Add(label_trussTempBR);
            groupBox.Controls.Add(textBox_trussTempBR);
            groupBox.Controls.Add(label_trussMeanTemp);
            groupBox.Controls.Add(textBox_trussMeanTemp);
            groupBox.Location = new System.Drawing.Point(42, 46);
            groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox.Size = new System.Drawing.Size(531, 550);
            groupBox.TabIndex = 8;
            groupBox.TabStop = false;
            groupBox.Text = "Sensors";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_coverState);
            groupBox1.Controls.Add(button_closecovers);
            groupBox1.Controls.Add(button_opencovers);
            groupBox1.Location = new System.Drawing.Point(616, 46);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(412, 279);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Covers";
            // 
            // comboBox_coverState
            // 
            comboBox_coverState.FormattingEnabled = true;
            comboBox_coverState.Location = new System.Drawing.Point(27, 55);
            comboBox_coverState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox_coverState.Name = "comboBox_coverState";
            comboBox_coverState.Size = new System.Drawing.Size(359, 40);
            comboBox_coverState.TabIndex = 6;
            comboBox_coverState.SelectionChangeCommitted += comboBox_coverState_SelectionChangeCommitted;
            // 
            // button_closecovers
            // 
            button_closecovers.Location = new System.Drawing.Point(207, 146);
            button_closecovers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_closecovers.Name = "button_closecovers";
            button_closecovers.Size = new System.Drawing.Size(179, 95);
            button_closecovers.TabIndex = 5;
            button_closecovers.Text = "Close Covers";
            button_closecovers.UseVisualStyleBackColor = true;
            button_closecovers.Click += button_closecovers_Click;
            // 
            // button_opencovers
            // 
            button_opencovers.Location = new System.Drawing.Point(27, 146);
            button_opencovers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_opencovers.Name = "button_opencovers";
            button_opencovers.Size = new System.Drawing.Size(168, 95);
            button_opencovers.TabIndex = 4;
            button_opencovers.Text = "Open Covers";
            button_opencovers.UseVisualStyleBackColor = true;
            button_opencovers.Click += button_opencovers_Click;
            // 
            // timer_refresh
            // 
            timer_refresh.Interval = 1000;
            timer_refresh.Tick += timer_refresh_Tick;
            //
            // groupBox4 (Fans)
            //
            // label_fanSpeed
            //
            label_fanSpeed.AutoSize = true;
            label_fanSpeed.Location = new System.Drawing.Point(27, 40);
            label_fanSpeed.Name = "label_fanSpeed";
            label_fanSpeed.Size = new System.Drawing.Size(120, 32);
            label_fanSpeed.TabIndex = 0;
            label_fanSpeed.Text = "Fan Speed";
            //
            // label_fanSpeedValue
            //
            label_fanSpeedValue.AutoSize = true;
            label_fanSpeedValue.Location = new System.Drawing.Point(300, 40);
            label_fanSpeedValue.Name = "label_fanSpeedValue";
            label_fanSpeedValue.Size = new System.Drawing.Size(50, 32);
            label_fanSpeedValue.TabIndex = 1;
            label_fanSpeedValue.Text = "Off";
            //
            // trackBar_fanSpeed
            //
            trackBar_fanSpeed.Location = new System.Drawing.Point(27, 80);
            trackBar_fanSpeed.Maximum = 4000;
            trackBar_fanSpeed.Minimum = 0;
            trackBar_fanSpeed.Name = "trackBar_fanSpeed";
            trackBar_fanSpeed.Size = new System.Drawing.Size(359, 90);
            trackBar_fanSpeed.SmallChange = 100;
            trackBar_fanSpeed.LargeChange = 500;
            trackBar_fanSpeed.TickFrequency = 100;
            trackBar_fanSpeed.TabIndex = 2;
            trackBar_fanSpeed.Scroll += trackBar_fanSpeed_Scroll;
            //
            groupBox4.Controls.Add(label_fanSpeed);
            groupBox4.Controls.Add(label_fanSpeedValue);
            groupBox4.Controls.Add(trackBar_fanSpeed);
            groupBox4.Location = new System.Drawing.Point(616, 340);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(412, 190);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fans";
            //
            // groupBox3 (Orientation MEMS)
            //
            // label_haAngle
            //
            label_haAngle.AutoSize = true;
            label_haAngle.Location = new System.Drawing.Point(28, 55);
            label_haAngle.Name = "label_haAngle";
            label_haAngle.Size = new System.Drawing.Size(120, 32);
            label_haAngle.TabIndex = 0;
            label_haAngle.Text = "HA Angle";
            //
            // textBox_haAngle
            //
            textBox_haAngle.Enabled = false;
            textBox_haAngle.Location = new System.Drawing.Point(228, 51);
            textBox_haAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_haAngle.Name = "textBox_haAngle";
            textBox_haAngle.ReadOnly = true;
            textBox_haAngle.Size = new System.Drawing.Size(143, 39);
            textBox_haAngle.TabIndex = 1;
            textBox_haAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label_decAngle
            //
            label_decAngle.AutoSize = true;
            label_decAngle.Location = new System.Drawing.Point(28, 125);
            label_decAngle.Name = "label_decAngle";
            label_decAngle.Size = new System.Drawing.Size(130, 32);
            label_decAngle.TabIndex = 2;
            label_decAngle.Text = "DEC Angle";
            //
            // textBox_decAngle
            //
            textBox_decAngle.Enabled = false;
            textBox_decAngle.Location = new System.Drawing.Point(228, 121);
            textBox_decAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_decAngle.Name = "textBox_decAngle";
            textBox_decAngle.ReadOnly = true;
            textBox_decAngle.Size = new System.Drawing.Size(143, 39);
            textBox_decAngle.TabIndex = 3;
            textBox_decAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label_altitude
            //
            label_altitude.AutoSize = true;
            label_altitude.Location = new System.Drawing.Point(28, 195);
            label_altitude.Name = "label_altitude";
            label_altitude.Size = new System.Drawing.Size(100, 32);
            label_altitude.TabIndex = 4;
            label_altitude.Text = "Altitude";
            //
            // textBox_altitude
            //
            textBox_altitude.Enabled = false;
            textBox_altitude.Location = new System.Drawing.Point(228, 191);
            textBox_altitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_altitude.Name = "textBox_altitude";
            textBox_altitude.ReadOnly = true;
            textBox_altitude.Size = new System.Drawing.Size(143, 39);
            textBox_altitude.TabIndex = 5;
            textBox_altitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label_azimuth
            //
            label_azimuth.AutoSize = true;
            label_azimuth.Location = new System.Drawing.Point(28, 265);
            label_azimuth.Name = "label_azimuth";
            label_azimuth.Size = new System.Drawing.Size(110, 32);
            label_azimuth.TabIndex = 6;
            label_azimuth.Text = "Azimuth";
            //
            // textBox_azimuth
            //
            textBox_azimuth.Enabled = false;
            textBox_azimuth.Location = new System.Drawing.Point(228, 261);
            textBox_azimuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_azimuth.Name = "textBox_azimuth";
            textBox_azimuth.ReadOnly = true;
            textBox_azimuth.Size = new System.Drawing.Size(143, 39);
            textBox_azimuth.TabIndex = 7;
            textBox_azimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            groupBox3.Controls.Add(label_haAngle);
            groupBox3.Controls.Add(textBox_haAngle);
            groupBox3.Controls.Add(label_decAngle);
            groupBox3.Controls.Add(textBox_decAngle);
            groupBox3.Controls.Add(label_altitude);
            groupBox3.Controls.Add(textBox_altitude);
            groupBox3.Controls.Add(label_azimuth);
            groupBox3.Controls.Add(textBox_azimuth);
            groupBox3.Location = new System.Drawing.Point(616, 545);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(412, 340);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Orientation (MEMS)";
            //
            // groupBox2
            //
            groupBox2.Controls.Add(button_primFocus);
            groupBox2.Controls.Add(button_cassFocus);
            groupBox2.Location = new System.Drawing.Point(42, 650);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(531, 192);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Focusers";
            // 
            // button_primFocus
            // 
            button_primFocus.Location = new System.Drawing.Point(278, 59);
            button_primFocus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_primFocus.Name = "button_primFocus";
            button_primFocus.Size = new System.Drawing.Size(225, 93);
            button_primFocus.TabIndex = 1;
            button_primFocus.Text = "Primary Focuser";
            button_primFocus.UseVisualStyleBackColor = true;
            button_primFocus.Click += button_primFocus_Click;
            // 
            // button_cassFocus
            // 
            button_cassFocus.Location = new System.Drawing.Point(28, 59);
            button_cassFocus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_cassFocus.Name = "button_cassFocus";
            button_cassFocus.Size = new System.Drawing.Size(225, 93);
            button_cassFocus.TabIndex = 0;
            button_cassFocus.Text = "Cassegrain Focuser";
            button_cassFocus.UseVisualStyleBackColor = true;
            button_cassFocus.Click += button_cassFocus_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1092, 950);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Telescope Control Panel";
            Load += MainForm_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar_fanSpeed)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_envtemp;
        private System.Windows.Forms.TextBox textBox_envhum;
        private System.Windows.Forms.TextBox textBox_m1celltemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_m1temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_opencovers;
        private System.Windows.Forms.Button button_closecovers;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.ComboBox comboBox_coverState;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_cassFocus;
        private System.Windows.Forms.Button button_primFocus;
        private System.Windows.Forms.Label label_trussTempTL;
        private System.Windows.Forms.TextBox textBox_trussTempTL;
        private System.Windows.Forms.Label label_trussTempBR;
        private System.Windows.Forms.TextBox textBox_trussTempBR;
        private System.Windows.Forms.Label label_trussMeanTemp;
        private System.Windows.Forms.TextBox textBox_trussMeanTemp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_haAngle;
        private System.Windows.Forms.TextBox textBox_haAngle;
        private System.Windows.Forms.Label label_decAngle;
        private System.Windows.Forms.TextBox textBox_decAngle;
        private System.Windows.Forms.Label label_altitude;
        private System.Windows.Forms.TextBox textBox_altitude;
        private System.Windows.Forms.Label label_azimuth;
        private System.Windows.Forms.TextBox textBox_azimuth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar_fanSpeed;
        private System.Windows.Forms.Label label_fanSpeed;
        private System.Windows.Forms.Label label_fanSpeedValue;
    }
}