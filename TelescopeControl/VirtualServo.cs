using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TelescopeControl
{
    internal class VirtualServo : IAbsoluteServo
    {



        public double minPosition => 0;

        public double maxPosition => 40.0;

        public double currentPosition { get; private set; } = 20.0;

        public bool isMoving
        {
            get
            {
                return Enabled && Math.Abs(targetPosition - currentPosition) > positionThreshold;
            }
        }

        private bool haltRequested = false;

        private double targetPosition;

        private double positionThreshold = 0.01;

        private Thread _moovLoopThread = null;
        private bool _enabled = false;
        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                if (value)
                {
                    _moovLoopThread = new Thread(MoveLoop);
                    _moovLoopThread.IsBackground = true;
                    _moovLoopThread.Start();
                } else
                {
                    _moovLoopThread.Join();
                }
            }
        }


        public VirtualServo()
        {
            // Make sure the servo doesnt move when it is created
            targetPosition = currentPosition;
        }



        private void MoveLoop()
        {
            while (Enabled)
            {
                if (haltRequested)
                {
                    haltRequested = false;
                    targetPosition = currentPosition;
                    continue;
                }
                if (Math.Abs(targetPosition - currentPosition) > positionThreshold)
                {
                    double step = Math.Min(0.2, Math.Abs(currentPosition - targetPosition));
                    if (targetPosition < currentPosition)
                    {
                        step = -step;
                    }

                    currentPosition += step;
                }
                Thread.Sleep(100);
            }
        }


        async public Task MoveTo(double position)
        {
            // Simulate moving the focuser, moves smoothly at 0.2mm/s

            if (position < minPosition || position > maxPosition)
            {
                throw new ArgumentOutOfRangeException("position", "Position must be between minPosition and maxPosition");
            }

            targetPosition = position;

            while (isMoving)
            {
                await Task.Delay(100);
            }

        }

        public void Halt()
        {
            haltRequested = true;
        }
    }
}
