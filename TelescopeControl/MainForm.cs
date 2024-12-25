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

        private TelescopePLC plc = new TelescopePLC("10.24.4.3");

        public MainForm()
        {
            InitializeComponent();
        }


        private void button_opencovers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cover operation not supported yet. Please use VNC and connect to the HMI panel to open the covers.");
        }

        private void button_closecovers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cover operation not supported yet. Please use VNC and connect to the HMI panel to close the covers.");
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
        }
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refreshUI();
        }
    }
}
