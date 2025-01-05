using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CMLCOMLib;

namespace TelescopeControl
{
    internal class AccelnetServo : IAbsoluteServo
    {

        canOpenObj canOpen;
        CopleyMotionLibraryObj cmlObj;
        AmpObj axisAmpObj;

        Object moveLock = new Object();

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
            axisAmpObj = new AmpObj();
            canOpen = new canOpenObj();

            canOpen.BitRate = CML_BIT_RATES.BITRATE_1_Mbit_per_sec;
            canOpen.PortName = canInterface;

            canOpen.Initialize();

            axisAmpObj.CountsPerUnit = countsPerUnit;

            axisAmpObj.Initialize(canOpen, canAddress);
            
        }


        public double minPosition {
            get
            {
                return axisAmpObj.SoftPositionPosLimit;
            }
        }
        
        public double maxPosition
        {
            get
            {
                return axisAmpObj.SoftPositionPosLimit;
            }
        }

        public double currentPosition
        {
            get
            {
                return axisAmpObj.PositionActual;
            }
        }

        public bool isMoving => throw new NotImplementedException();

        public void Halt()
        {
            axisAmpObj.HaltMode = CML_HALT_MODE.HALT_DECEL;
            axisAmpObj.HaltMove();
        }

        async public Task MoveTo(double position)
        {
            await Task.Run(() =>
            {
                lock(moveLock)
                {
                    axisAmpObj.MoveAbs(position);
                    axisAmpObj.WaitMoveDone(60_000);
                }
            });
        }

        ~AccelnetServo()
        {
            Enabled = false;
        }
    }
}
