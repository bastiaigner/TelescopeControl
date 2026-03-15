using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl
{
    internal class FocuserTemperatureFromPLCAdapter: IFocuserTemperatureSource
    {
        private TelescopePLC plc;
        private DateTime lastReadTime = DateTime.MinValue;
        private double lastReadValue = 0;
        private double refreshInterval = 15;

        public FocuserTemperatureFromPLCAdapter(TelescopePLC plc)
        {
            this.plc = plc;
            plc.Connect();
        }

        public double temperature
        {
            get
            {
                if (DateTime.Now - lastReadTime > TimeSpan.FromSeconds(refreshInterval))
                {
                    lastReadTime = DateTime.Now;
                    lastReadValue = plc.ReadTrussMeanTemperature();
                }
                return lastReadValue;
            }
        }

        ~FocuserTemperatureFromPLCAdapter()
        {
            plc.Disconnect();
        }
    }
}
