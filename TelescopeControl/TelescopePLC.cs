using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Configuration;
using TelescopeControl.Properties;
using System.ComponentModel;

namespace TelescopeControl
{

    internal struct AnalogValues
    {
        public double M1Temperature;
        public double MirrorCellTemperature;
        public double EnvironmentTemperature;
        public double EnvironmentHumidity;
    }






    public class TelescopePLC: IDisposable
    {

        public static TelescopePLC Instance { get; } = new TelescopePLC(Properties.Settings.Default.PLCHost);

        private string hostname;
        private bool connected;

        private Plc plc;

        private AnalogValues _analogValues;
        private DateTime _lastReadTime;



        public TelescopePLC(string hostname)
        {
            this.hostname = hostname;
        }

        public void Connect()
        {
            plc = new Plc(CpuType.S71200, hostname, 0, 1);
            plc.Open();
            connected = true;
        }

        public void Disconnect()
        {
            plc.Close();
            connected = false;
        }

        public double ReadEnvironmentTemperature()
        {
           maybeRefreshAnalogValues();
            return _analogValues.EnvironmentTemperature;
        }

        public double ReadEnvironmentHumidity()
        {
            maybeRefreshAnalogValues();
            return _analogValues.EnvironmentHumidity;
        }


        public double ReadMirrorCellTemperature()
        {
            maybeRefreshAnalogValues();
            return _analogValues.MirrorCellTemperature;
        }

        public double ReadM1Temperature()
        {
            maybeRefreshAnalogValues();
            return _analogValues.M1Temperature;
        }

        public FlapState ReadFlapState()
        {
            var result = plc.Read(DataType.DataBlock, 2, 0, VarType.Int, 1);
            if (result == null)
            {
                throw new Exception("Failed to read value from PLC");
            }

            return (FlapState)((short)result);
        }

        public void SetFlapState(FlapState state)
        {
            plc.Write(DataType.DataBlock, 2, 0, (short)state);
        }


        public bool GetFlapIsAutomaticMode()
        {
            var result = plc.Read(DataType.DataBlock, 2, 2, VarType.Bit, 1);
            if (result == null)
            {
                throw new Exception("Failed to read value from PLC");
            }
            return (bool)result;
        }

        public void SetFlapIsAutomaticMode(bool value)
        {
            throw new Exception("Not implemented for now (for safety reasons)");
            plc.Write(DataType.DataBlock, 2, 2, value);
        }


        private void refreshAnalogValues()
        {
            var result = plc.Read(DataType.DataBlock, 5, 0, VarType.Real, 4);
            if (result == null)
            {
                throw new Exception("Failed to read value from PLC");
            }

            this._analogValues = new AnalogValues
            {
                M1Temperature = (double)((float[])result)[0],
                MirrorCellTemperature = (double)((float[])result)[1],
                EnvironmentTemperature = (double)((float[])result)[2],
                EnvironmentHumidity = (double)((float[])result)[3]
            };

            this._lastReadTime = DateTime.Now;
        }

        private void maybeRefreshAnalogValues()
        {
            if (DateTime.Now - _lastReadTime > TimeSpan.FromSeconds(1))
            {
                refreshAnalogValues();
            }
        }

        public void Dispose()
        {
            if (connected)
            {
                Disconnect();
            }
        }
    }

    public enum FlapState
    {
        FullyClosed = 0,
        LeftMirrorDoorOpen = 1,
        MirrorDoorsOpen = 2,
        MirrorDoorsAndFlapM1Open = 3,
        MirrorDoorsAndFlapsOpen = 4,
    }
}
