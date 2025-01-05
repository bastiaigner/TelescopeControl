using System.Windows.Forms;
using ENVInterface;
using TelescopeControl;


namespace TelescopeControlAutoslew
{
    public class StaticEnvironment : I_Environment
    {
        private bool DidTerminate;

        private const double MinimumWaitTime = 2.0;

        private TelescopePLC plc = TelescopePLC.Instance;

        public bool CanMeasureTemperature
        {
            get
            {
                return true;
            }
        }

        public bool CanMeasureHumidity => true;

        public bool CanMeasurePressure => true;

        public bool SensorsReady
        {
            get
            {
                return true;
            }
        }

        public bool SensorReady
        {
            get
            {
                return true;
            }
        }


        public double Humidity
        {
            get
            {
                return 70.2;
            }
        }

        public double Pressure
        {
            get
            {
                return 1001.0;
            }
        }

        public bool Init
        {
            get
            {
                try
                {
                    plc.Connect();
                }
                catch (System.Exception e)
                {
                    MessageBox.Show("Failed to connect to PLC: " + e.Message);
                    return false;
                }

                return true;
            }
        }


        public short InstalledTempSensors
        {
            get
            {
                return 3;
            }
        }


        public void Close()
        {

        }



        public void Setup()
        {
            
        }

        public double get_Temperature(short Number)
        {
            return 3.6 + (double)Number * 10.0;
        }
    }


    public class Environment: I_Environment
    {

        TelescopePLC plc = new TelescopePLC("10.24.4.3");

        public bool CanMeasureTemperature => true;

        public bool CanMeasureHumidity => true;

        public bool CanMeasurePressure => false;

        public bool SensorsReady {
            get
            {
                return plc.IsConnected();
            }
        }

        public double Humidity {
            get
            {
                return plc.ReadEnvironmentHumidity();
            }
        }

        public double Pressure => throw new System.NotImplementedException();

        public bool Init
        {
            get
            {
                try { 
                    plc.Connect();
                    return true;
                }
                catch { 
                    return false;
                }
            }
        }

        public short InstalledTempSensors => 3;

        public void Close()
        {
            plc.Disconnect();
        }

        public double get_Temperature(short Number)
        {
            switch (Number)
            {
                case 1:
                   return plc.ReadEnvironmentTemperature();
                case 2:
                    return plc.ReadM1Temperature();
                default:
                    throw new System.NotImplementedException();
            }
        }

        public void Setup()
        {
            throw new System.NotImplementedException();
        }

        ~Environment()
        {
            plc.Disconnect();
        }
    }
}
