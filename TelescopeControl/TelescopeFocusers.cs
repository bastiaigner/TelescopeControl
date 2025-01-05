using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl
{
    internal static class TelescopeFocusers
    {

        private static FocuserTemperatureFromPLCAdapter plcAdapter = new FocuserTemperatureFromPLCAdapter(TelescopePLC.Instance);

        public static AbsoluteFocuser cassegrainFocuser = new AbsoluteFocuser("Cassegrain Focuser", new VirtualServo(), plcAdapter);
        public static AbsoluteFocuser primaryFocuser = new AbsoluteFocuser("Primary Focuser", new VirtualServo(), plcAdapter);
    }
}
