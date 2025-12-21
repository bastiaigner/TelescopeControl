using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelescopeControl
{
    public partial class FocuserForm : Form
    {

        private AbsoluteFocuser focuser;

        public FocuserForm(AbsoluteFocuser focuser)
        {
            this.focuser = focuser;

            InitializeComponent();
            refreshFocuserValues();

            this.Text = focuser.name + " (" + focuser.servo.GetType().Name + ")";

            timer_refreshUI.Start();

            if (!focuser.IsHomed)
            {
                MessageBox.Show("Warning: The focuser servo has not been homed. Please home the servo before use.", "Focuser Not Homed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshFocuserValues()
        {
            label_min.Text = formatPosition(focuser.minPosition);
            label_max.Text = formatPosition(focuser.maxPosition);

            trackBar_position.Minimum = (int)focuser.minPosition;
            trackBar_position.Maximum = (int)focuser.maxPosition;

            textBox_focusPosition.Text = formatPosition(focuser.currentPosition);

            if (!trackBar_position.Capture)
            {
                trackBar_position.Value = (int)focuser.currentPosition;
            }

            textBox_focusPosition.BackColor = focuser.isMoving ? Color.LightGreen : Color.White;


            // Update temperature compensation

            label_currTemp.Text = focuser.currentTemperature.ToString("00.00") + " °C";
            label_deltaTemp.Text = focuser.originalTemperature != null ? (focuser.currentTemperature - focuser.originalTemperature).Value.ToString("00.00") + " °C" : "N/A";
            label_origPosition.Text = focuser.originalSetPosition != null ? formatPosition(focuser.originalSetPosition.Value) : "N/A";

            label_lastCompensation.Text = focuser.lastTemperatureCompensation != null ? focuser.lastTemperatureCompensation.Value.ToShortTimeString() : "N/A";

            checkBox_continuosCompensation.Checked = focuser.continuousTemperatureCompensation;
            checkBox_calibrateOnMove.Checked = focuser.calibrateOnMove;

            if (!textBox_compRate.Focused)
            {
                textBox_compRate.Text = focuser.temperatureCompensationRate.ToString("0.0000");
            }

            checkBox_enabled.Checked = focuser.Enabled;
            trackBar_position.Enabled = focuser.Enabled;

            label_homingStatus.Text = focuser.IsHomed ? "Servo Homed" : "Needs Homing!";

        }

        private void MoveToPosition(double position)
        {
            try
            {
                Task moveTask = focuser.MoveTo(position);
                moveTask.ContinueWith((t) =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Error: " + t.Exception.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private String formatPosition(double position)
        {
            return position.ToString("0.00") + " mm";
        }

        private void timer_refreshUI_Tick(object sender, EventArgs e)
        {
            refreshFocuserValues();
        }

        private void trackBar_position_Scroll(object sender, EventArgs e)
        {
            MoveToPosition((double)trackBar_position.Value);
        }

        private void button_halt_Click(object sender, EventArgs e)
        {
            focuser.Halt();
        }

        private async void button_RunCompenationNow_Click(object sender, EventArgs e)
        {
            try
            {
                await focuser.MoveToCompensateTemperature();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_calibrateNow_Click(object sender, EventArgs e)
        {
            focuser.CalibrateTemperature();
        }

        private void textBox_compRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                focuser.temperatureCompensationRate = double.Parse(textBox_compRate.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void checkBox_continuosCompensation_CheckedChanged(object sender, EventArgs e)
        {
            focuser.continuousTemperatureCompensation = ((CheckBox)sender).Checked;
        }

        private void checkBox_calibrateOnMove_CheckedChanged(object sender, EventArgs e)
        {
            focuser.calibrateOnMove = ((CheckBox)sender).Checked;
        }

        private void checkBox_enabled_CheckedChanged(object sender, EventArgs e)
        {
            focuser.Enabled = ((CheckBox)sender).Checked;
        }

        private void button_homeServo_Click(object sender, EventArgs e)
        {
            try
            {
                Task homeTask = focuser.Home();
                homeTask.ContinueWith((t) => 
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Error: " + t.Exception.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
