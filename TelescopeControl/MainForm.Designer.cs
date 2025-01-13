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
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox.Location = new System.Drawing.Point(42, 46);
            groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox.Size = new System.Drawing.Size(531, 374);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(button_primFocus);
            groupBox2.Controls.Add(button_cassFocus);
            groupBox2.Location = new System.Drawing.Point(42, 476);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(583, 192);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Focusers";
            // 
            // button_primFocus
            // 
            button_primFocus.Location = new System.Drawing.Point(291, 59);
            button_primFocus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_primFocus.Name = "button_primFocus";
            button_primFocus.Size = new System.Drawing.Size(239, 93);
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
            button_cassFocus.Size = new System.Drawing.Size(239, 93);
            button_cassFocus.TabIndex = 0;
            button_cassFocus.Text = "Cassegrain Focuser";
            button_cassFocus.UseVisualStyleBackColor = true;
            button_cassFocus.Click += button_cassFocus_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1092, 732);
            Controls.Add(groupBox2);
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
    }
}