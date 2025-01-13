using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CMLCOMLib;

namespace TelescopeControl
{
    internal class AccelnetServo : IAbsoluteServo, IDisposable
    {

        canOpenObj canOpen;
        CopleyMotionLibraryObj cmlObj;
        AmpObj axisAmpObj;

        private int countsPerUnit;


        public bool Enabled
        {
            get
            {
                return axisAmpObj.IsSoftwareEnabled;
            }

            set
            {
                if (value)
                {
                    axisAmpObj.Enable();
                } else
                {
                    axisAmpObj.Disable();
                }
            }
        }


        public AccelnetServo(String canInterface, short canAddress, int countsPerUnit)
        {
            cmlObj = new CopleyMotionLibraryObj();

            //const int LOG_ALL = 99;
            //cmlObj.DebugLevel = LOG_ALL;

            axisAmpObj = new AmpObj();
            canOpen = new canOpenObj();

            canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
            canOpen.PortName = canInterface;

            canOpen.Initialize();

            var ampSettings = new ampSettingsObj();
            ampSettings.guardTime = 0;

            //axisAmpObj.CountsPerUnit = countsPerUnit;
            axisAmpObj.InitializeExt(canOpen, canAddress, ampSettings);

    
            

            this.countsPerUnit = countsPerUnit;

        }


        public double minPosition {
            get
            {
                return axisAmpObj.SoftPositionNegLimit / countsPerUnit;
            }
        }
        
        public double maxPosition
        {
            get
            {
                return axisAmpObj.SoftPositionPosLimit / countsPerUnit;
            }
        }

        public double currentPosition
        {
            get
            {
                return axisAmpObj.PositionActual / countsPerUnit;
            }
        }

        public bool isMoving
        {
            get
            {
                CML_EVENT_STATUS eventStatus = 0;
                axisAmpObj.ReadEventStatus(ref eventStatus);
                return (eventStatus & CML_EVENT_STATUS.EVENT_STATUS_MOVING) == CML_EVENT_STATUS.EVENT_STATUS_MOVING;
            }
        }

        public void Halt()
        {
            axisAmpObj.HaltMode = CML_HALT_MODE.HALT_DECEL;
            axisAmpObj.HaltMove();
        }

        async public Task MoveTo(double position)
        {
            axisAmpObj.MoveAbs(position * countsPerUnit);
        }

        public void Dispose()
        {
            Enabled = false;

            canOpen.Close();
        }
    }
}
