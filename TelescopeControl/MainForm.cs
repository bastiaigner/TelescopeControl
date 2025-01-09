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
    public partial class MainForm : Form
    {

        private TelescopePLC plc = TelescopePLC.Instance;

        public MainForm()
        {
            InitializeComponent();
            comboBox_coverState.DataSource = Enum.GetValues(typeof(FlapState));
        }


        private void button_opencovers_Click(object sender, EventArgs e)
        {
            TryToSetFlapState(FlapState.MirrorDoorsAndFlapsOpen);
        }

        private void button_closecovers_Click(object sender, EventArgs e)
        {
            TryToSetFlapState(FlapState.FullyClosed);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            plc.Connect();

            refreshUI();
            timer_refresh.Start();

        }


        private void refreshUI()
        {
            textBox_envtemp.Text = String.Format("{0:00.0} °C", plc.ReadEnvironmentTemperature());
            textBox_envhum.Text = String.Format("{0:00} %", plc.ReadEnvironmentHumidity());
            textBox_m1temp.Text = String.Format("{0:00.0} °C", plc.ReadM1Temperature());
            textBox_m1celltemp.Text = String.Format("{0:00.0} °C", plc.ReadMirrorCellTemperature());

            comboBox_coverState.SelectedItem = TelescopePLC.Instance.ReadFlapState();
            comboBox_coverState.Enabled = plc.GetFlapIsAutomaticMode();

        }
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void button_cassFocus_Click(object sender, EventArgs e)
        {
            FocuserForm focuserForm = new FocuserForm(TelescopeFocusers.cassegrainFocuser);
            focuserForm.Show();
        }

        private void button_primFocus_Click(object sender, EventArgs e)
        {
            FocuserForm focuserForm = new FocuserForm(TelescopeFocusers.primaryFocuser);
            focuserForm.Show();
        }

        private void TryToSetFlapState(FlapState state)
        {
            if (plc.GetFlapIsAutomaticMode())
            {
                plc.SetFlapState(state);
            }
            else
            {
                MessageBox.Show("Flap is not in automatic mode. Please switch to automatic mode in the HMI panel.");
            }
        }

        private void comboBox_coverState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TryToSetFlapState((FlapState)comboBox_coverState.SelectedItem);
        }
    }
}
