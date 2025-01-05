using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace TelescopeControl
{

    public class TelescopePLC
    {

        public static TelescopePLC Instance { get; } = new TelescopePLC("10.24.4.3");

        private string hostname;
        private bool connected;

        private Plc plc;

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
           return readRealValue(2);
        }

        public double ReadEnvironmentHumidity()
        {
            return readRealValue(3);
        }


        public double ReadMirrorCellTemperature()
        {
            return readRealValue(1);
        }

        public double ReadM1Temperature()
        {
            return readRealValue(0);
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
            plc.Write(DataType.DataBlock, 2, 2, value);
        }



        private double readRealValue(int offset)
        {
            var result = plc.Read(DataType.DataBlock, 5, 0, VarType.Real, 4);

            if (result == null)
            {
                throw new Exception("Failed to read value from PLC");
            }

            return (double)(((float[])result)[offset]);
            //return (double)((uint)result).ConvertToFloat();
        }

        ~TelescopePLC()
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
