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

        public bool IsConnected()
        {
            return plc.IsConnected;
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
}
