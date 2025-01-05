using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterfaces;
using System.Windows.Forms;

namespace TelescopeControlAutoslew
{
    internal class Servos : IServos
    {
        public bool CoversInstalled => true;

        public bool FansInstalled => false;

        public int FanSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Init
        {
            get {
                return true;
            }
        }

        public short InstalledAxis => 0;

        public bool IsInSetup => false;

        public bool LaserIsInstalled => false;

        public bool LaserOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name => "S7-based Flaps and Mirror Doors";

        public bool TertiaryInstalled => false;

        public string Action(string ActionName, string ActionParameters)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void CoversClose()
        {
            MessageBox.Show("CoversClose");
        }

        public void CoversOpen()
        {
            MessageBox.Show("CoversOpen");
        }

        public void ErrorClear(short Axis)
        {
            throw new NotImplementedException();
        }

        public double get_Acceleration(short Axis)
        {
            throw new NotImplementedException();
        }

        public bool get_AnalogIsInstalled(short Ax)
        {
            throw new NotImplementedException();
        }

        public double get_AnalogPosition(short Ax, bool HadError)
        {
            throw new NotImplementedException();
        }

        public short get_ErrorAction(short Axis)
        {
            throw new NotImplementedException();
        }

        public short get_ErrorNumber(short Axis)
        {
            throw new NotImplementedException();
        }

        public bool get_ErrorRaised(short Axis)
        {
            throw new NotImplementedException();
        }

        public string get_ErrorString(short Axis)
        {
            throw new NotImplementedException();
        }

        public bool get_HomeFindActive(short Ax)
        {
            throw new NotImplementedException();
        }

        public bool get_HomeFound(short Ax)
        {
            throw new NotImplementedException();
        }

        public double get_MaxAcc(short Axis)
        {
            throw new NotImplementedException();
        }

        public double get_MaxSpeed(short Axis)
        {
            throw new NotImplementedException();
        }

        public bool get_MotorOn(short Axis)
        {
            throw new NotImplementedException();
        }

        public double get_MotorTemperature(short Axis, bool HadError)
        {
            throw new NotImplementedException();
        }

        public bool get_MotorTempSensorInstalled(short Axis)
        {
            throw new NotImplementedException();
        }

        public bool get_Moving(short Axis, bool HadError)
        {
            throw new NotImplementedException();
        }

        public double get_PositionError(short Ax, bool HadError)
        {
            throw new NotImplementedException();
        }

        public double get_PosSpeed(short Axis)
        {
            throw new NotImplementedException();
        }

        public double get_Resolution(short Axis)
        {
            throw new NotImplementedException();
        }

        public double get_ServoPosition(short Axis, bool HadError)
        {
            throw new NotImplementedException();
        }

        public double get_VelSpeed(short Axis)
        {
            throw new NotImplementedException();
        }

        public void Halt(short Axis)
        {
            throw new NotImplementedException();
        }

        public void HomeFindIndexPos(short Ax)
        {
            throw new NotImplementedException();
        }

        public void SaveParameters()
        {
            throw new NotImplementedException();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }

        public void set_Acceleration(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_AnalogSynch(short Ax, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_MotorOn(short Axis, bool Value)
        {
            throw new NotImplementedException();
        }

        public void set_MoveRelative(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_PosSpeed(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_Resolution(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_Synch(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void set_VelSpeed(short Axis, double Value)
        {
            throw new NotImplementedException();
        }

        public void TertiaryStop()
        {
            throw new NotImplementedException();
        }

        public void TertiaryTurnLeft()
        {
            throw new NotImplementedException();
        }

        public void TertiaryTurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
