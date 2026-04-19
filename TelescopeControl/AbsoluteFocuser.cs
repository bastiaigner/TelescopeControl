using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TelescopeControl
{
    public class AbsoluteFocuser
    {
        public IAbsoluteServo servo { get; private set; }
        private IFocuserTemperatureSource temperatureSource;

        private Timer temperatureCompensationTimer;

        public String name { get; private set; }

        public AbsoluteFocuser(String name, IAbsoluteServo servo, IFocuserTemperatureSource temperatureSource)
        {
            this.name = name;
            this.servo = servo;
            this.temperatureSource = temperatureSource;

            this.servo.Enabled = true;

            temperatureCompensationTimer = new Timer(1000 * 60 * 3); // Check every three minutes
            temperatureCompensationTimer.Elapsed += TemperatureCompensationTimer_Elapsed;
            temperatureCompensationTimer.AutoReset = true;

        }

        private void TemperatureCompensationTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (continuousTemperatureCompensation && Enabled && !isMoving)
            {
                MoveToCompensateTemperature().Wait();
            }
        }




        public async Task MoveTo(double position, bool withoutTemperatureRecalibration=false)
        {

            if (!Enabled)
            {
                throw new InvalidOperationException("Focuser is not enabled");
            }

            if ( position > maxPosition || position < minPosition)
            {
                throw new ArgumentOutOfRangeException("Position out of range");
            }
   
            await servo.MoveTo(position);
            if (calibrateOnMove && !withoutTemperatureRecalibration)
            {
                CalibrateTemperature(position);
            }
        }
        
        public void Halt()
        {
            servo.Halt();
        }

        public bool Enabled
        {
            get { return servo.Enabled; }
            set
            {   
                servo.Enabled = value;

                if (value)
                {
                    temperatureCompensationTimer.Start();
                } else
                {
                    temperatureCompensationTimer.Stop();
                }
            }
        }
        public double minPosition => servo.minPosition;

        public double maxPosition => servo.maxPosition;

        public double currentPosition => servo.currentPosition;

        public bool isMoving => servo.isMoving;

        public bool IsHomed => servo.IsHomed;

        public async Task Home()
        {
            await servo.Home();
        }

        // Rate in mm/deg C by which the focuser position changes with temperature
        public double temperatureCompensationRate = 0.0;

        // If true, the focuser will automatically adjust its position to compensate for temperature changes
        public bool continuousTemperatureCompensation = false;

        // If true, the focuser will automatically set a new calibration point when it is moved
        public bool calibrateOnMove = false;

        // The temperature at which the focuser was last calibrated
        public double? originalSetPosition { get; private set; }
       
        // The temperature at which the focuser was last calibrated
        public double? originalTemperature { get; private set; }



        public double currentTemperature
        {
            get
            {
                return temperatureSource.temperature;
            }
        }

        public async Task MoveToCompensateTemperature()
        {
            if (originalSetPosition != null && temperatureCompensationDistance != null)
            {
                double targetPosition = originalSetPosition.Value + temperatureCompensationDistance.Value;
                await MoveTo(targetPosition, true);
                lastTemperatureCompensation = DateTime.Now;
            } else
            {
                throw new InvalidOperationException("Cannot compensate temperature without calibration");
            }
          
        }

        public void CalibrateTemperature(double? atPosition = null)
        {
            originalSetPosition = atPosition ?? currentPosition;
            originalTemperature = currentTemperature;
        }

        public double? temperatureCompensationDistance
        {
            get
            {
                if (originalTemperature == null)
                {
                    return null;
                }
                return temperatureCompensationRate * (currentTemperature - originalTemperature);
            }
        }

        public DateTime? lastTemperatureCompensation { get; private set; }

    }
}
