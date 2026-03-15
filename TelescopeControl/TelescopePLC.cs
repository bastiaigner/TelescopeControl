using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Configuration;
using TelescopeControl.Properties;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Collections;

namespace TelescopeControl
{

    internal struct AnalogValues
    {
        public double M1Temperature;
        public double MirrorCellTemperature;
        public double EnvironmentTemperature;
        public double EnvironmentHumidity;
        public double HAAngle;
        public double DECAngle;
        public double Altitude;
        public double Azimuth;
        public double TrussTempTopLeft;
        public double TrussTempBottomRight;
    }

    public struct FlapMovingState
    {
        public bool FlapM1Open;
        public bool FlapM1Close;
        public bool FlapM2Open;
        public bool FlapM2Close;
        public bool MirrorDoorLeftOpen;
        public bool MirrorDoorLeftClose;
        public bool MirrorDoorRightOpen;
        public bool MirrorDoorRightClose;

        public bool IsMoving
        {
            get { return FlapM1Open || FlapM1Close || FlapM2Open || FlapM2Close || MirrorDoorLeftOpen || MirrorDoorLeftClose || MirrorDoorRightOpen || MirrorDoorRightClose; }
        }

    }



    public class TelescopePLC: IDisposable
    {

        public static TelescopePLC Instance { get; } = new TelescopePLC(Properties.Settings.Default.PLCHost);

        public string hostname { get; private set; }
        public bool connected { get; private set; }

        private Plc plc;

        private AnalogValues _analogValues;
        private DateTime _lastAnalogValuesReadTime;



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

        public double ReadHAAngle()
        {
            maybeRefreshAnalogValues();
            return _analogValues.HAAngle;
        }

        public double ReadDECAngle()
        {
            maybeRefreshAnalogValues();
            return _analogValues.DECAngle;
        }

        public double ReadAltitude()
        {
            maybeRefreshAnalogValues();
            return _analogValues.Altitude;
        }

        public double ReadAzimuth()
        {
            maybeRefreshAnalogValues();
            return _analogValues.Azimuth;
        }

        public double ReadTrussTempTopLeft()
        {
            maybeRefreshAnalogValues();
            return _analogValues.TrussTempTopLeft;
        }

        public double ReadTrussTempBottomRight()
        {
            maybeRefreshAnalogValues();
            return _analogValues.TrussTempBottomRight;
        }

        public double ReadTrussMeanTemperature()
        {
            maybeRefreshAnalogValues();
            return (_analogValues.TrussTempTopLeft + _analogValues.TrussTempBottomRight) / 2.0;
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
            var result = plc.Read(DataType.DataBlock, 5, 0, VarType.Real, 10);
            if (result == null)
            {
                throw new Exception("Failed to read value from PLC");
            }

            var values = (float[])result;
            this._analogValues = new AnalogValues
            {
                M1Temperature = (double)values[0],
                MirrorCellTemperature = (double)values[1],
                EnvironmentTemperature = (double)values[2],
                EnvironmentHumidity = (double)values[3],
                HAAngle = (double)values[4],
                DECAngle = (double)values[5],
                Altitude = (double)values[6],
                Azimuth = (double)values[7],
                TrussTempTopLeft = (double)values[8],
                TrussTempBottomRight = (double)values[9]
            };

            this._lastAnalogValuesReadTime = DateTime.Now;
        }

        public FlapMovingState ReadFlapMovingState()
        {
            BitArray data = (BitArray)plc.Read(DataType.Output, 53, 0, VarType.Bit, 8);
            if (data == null)
            {
                throw new Exception("Failed to read value from PLC");
            }

            FlapMovingState state = new FlapMovingState
            {
                FlapM1Open = (bool)data[0],
                FlapM1Close = (bool)data[1],
                FlapM2Open = (bool)data[2],
                FlapM2Close = (bool)data[3],
                MirrorDoorLeftOpen = (bool)data[4],
                MirrorDoorLeftClose = (bool)data[5],
                MirrorDoorRightOpen = (bool)data[6],
                MirrorDoorRightClose = (bool)data[7]
            };

            return state;

        }

        private void maybeRefreshAnalogValues()
        {
            if (DateTime.Now - _lastAnalogValuesReadTime > TimeSpan.FromSeconds(1))
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
