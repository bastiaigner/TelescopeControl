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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_envtemp = new System.Windows.Forms.TextBox();
            this.textBox_envhum = new System.Windows.Forms.TextBox();
            this.textBox_m1celltemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_m1temp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_closecovers = new System.Windows.Forms.Button();
            this.button_opencovers = new System.Windows.Forms.Button();
            this.textBox_coverstate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Environment Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Environment Humidity";
            // 
            // textBox_envtemp
            // 
            this.textBox_envtemp.Enabled = false;
            this.textBox_envtemp.Location = new System.Drawing.Point(321, 40);
            this.textBox_envtemp.Name = "textBox_envtemp";
            this.textBox_envtemp.ReadOnly = true;
            this.textBox_envtemp.Size = new System.Drawing.Size(132, 31);
            this.textBox_envtemp.TabIndex = 2;
            this.textBox_envtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_envhum
            // 
            this.textBox_envhum.Enabled = false;
            this.textBox_envhum.Location = new System.Drawing.Point(321, 95);
            this.textBox_envhum.Name = "textBox_envhum";
            this.textBox_envhum.ReadOnly = true;
            this.textBox_envhum.Size = new System.Drawing.Size(132, 31);
            this.textBox_envhum.TabIndex = 3;
            this.textBox_envhum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_m1celltemp
            // 
            this.textBox_m1celltemp.Enabled = false;
            this.textBox_m1celltemp.Location = new System.Drawing.Point(321, 205);
            this.textBox_m1celltemp.Name = "textBox_m1celltemp";
            this.textBox_m1celltemp.ReadOnly = true;
            this.textBox_m1celltemp.Size = new System.Drawing.Size(132, 31);
            this.textBox_m1celltemp.TabIndex = 7;
            this.textBox_m1celltemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "M1 Temperature";
            // 
            // textBox_m1temp
            // 
            this.textBox_m1temp.Enabled = false;
            this.textBox_m1temp.Location = new System.Drawing.Point(321, 150);
            this.textBox_m1temp.Name = "textBox_m1temp";
            this.textBox_m1temp.ReadOnly = true;
            this.textBox_m1temp.Size = new System.Drawing.Size(132, 31);
            this.textBox_m1temp.TabIndex = 6;
            this.textBox_m1temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "M1 Cell Temperature";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBox_m1celltemp);
            this.groupBox.Controls.Add(this.textBox_envtemp);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.textBox_m1temp);
            this.groupBox.Controls.Add(this.textBox_envhum);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Location = new System.Drawing.Point(39, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(490, 292);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sensors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_closecovers);
            this.groupBox1.Controls.Add(this.button_opencovers);
            this.groupBox1.Controls.Add(this.textBox_coverstate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(569, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Covers";
            // 
            // button_closecovers
            // 
            this.button_closecovers.Location = new System.Drawing.Point(191, 114);
            this.button_closecovers.Name = "button_closecovers";
            this.button_closecovers.Size = new System.Drawing.Size(165, 74);
            this.button_closecovers.TabIndex = 5;
            this.button_closecovers.Text = "Close Covers";
            this.button_closecovers.UseVisualStyleBackColor = true;
            this.button_closecovers.Click += new System.EventHandler(this.button_closecovers_Click);
            // 
            // button_opencovers
            // 
            this.button_opencovers.Location = new System.Drawing.Point(25, 114);
            this.button_opencovers.Name = "button_opencovers";
            this.button_opencovers.Size = new System.Drawing.Size(155, 74);
            this.button_opencovers.TabIndex = 4;
            this.button_opencovers.Text = "Open Covers";
            this.button_opencovers.UseVisualStyleBackColor = true;
            this.button_opencovers.Click += new System.EventHandler(this.button_opencovers_Click);
            // 
            // textBox_coverstate
            // 
            this.textBox_coverstate.Enabled = false;
            this.textBox_coverstate.Location = new System.Drawing.Point(206, 51);
            this.textBox_coverstate.Name = "textBox_coverstate";
            this.textBox_coverstate.ReadOnly = true;
            this.textBox_coverstate.Size = new System.Drawing.Size(150, 31);
            this.textBox_coverstate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telescope PLC: 10.24.4.3 (S7-1200)";
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 2500;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Telescope Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_opencovers;
        private System.Windows.Forms.TextBox textBox_coverstate;
        private System.Windows.Forms.Button button_closecovers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer_refresh;
    }
}