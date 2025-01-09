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

        public static AbsoluteFocuser cassegrainFocuser = new AbsoluteFocuser("Cassegrain Focuser", getCassegrainServo(), plcAdapter);
        public static AbsoluteFocuser primaryFocuser = new AbsoluteFocuser("Primary Focuser", getPrimaryServo(), plcAdapter);

        private static IAbsoluteServo getCassegrainServo()
        {
            if (Properties.Settings.Default.CANInterface != "" && Properties.Settings.Default.CANNodeCassegrainFocuser > 0)
            {
                return new AccelnetServo(
                    Properties.Settings.Default.CANInterface,
                    (short)Properties.Settings.Default.CANNodeCassegrainFocuser,
                    (int)Properties.Settings.Default.CassegrainFocuserCountsToMM
                );
            }
            else
            {
                return new VirtualServo();
            }

        }

        private static IAbsoluteServo getPrimaryServo()
        {
            if (Properties.Settings.Default.CANInterface != "" && Properties.Settings.Default.CANNodePrimaryFocuser > 0)
            {
                return new AccelnetServo(
                    Properties.Settings.Default.CANInterface,
                    (short)Properties.Settings.Default.CANNodePrimaryFocuser,
                    (int)Properties.Settings.Default.PrimaryFocuserCountsToMM
                );
            }
            else
            {
                return new VirtualServo();
            }
        }
    }
}
