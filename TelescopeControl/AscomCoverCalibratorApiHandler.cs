using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Formatters;
using TelescopeControl.Alpaca.Exceptions;

namespace TelescopeControl
{
    internal class AscomCoverCalibratorApiHandler : AscomDeviceApiHandler
    {
        private TelescopePLC _plc;
        public AscomCoverCalibratorApiHandler(int deviceNumber, TelescopePLC plc) : base("covercalibrator", deviceNumber)
        {
            _plc = plc;
        }

        public override void RegisterRoutes(WebApplication app)
        {
            RegisterCommonRoutes(app);

            RegisterRoute(app, "GET", "driverversion", (request) =>
            {
                return "1.0";
            });

            RegisterRoute(app, "GET", "connected", (request) =>
            {
                return _plc.connected;
            });

            RegisterRoute<object>(app, "PUT", "connected", (request) =>
            {
                return null;
            });

            RegisterRoute<object>(app, "PUT", "connect", (request) =>
            {
                return null;
            });

            RegisterRoute<object>(app, "PUT", "disconnect", (request) =>
            {
                return null;
            });

            RegisterRoute(app, "GET", "connecting", (request) =>
            {
                // In our case, the PLC is always connected
                return false;
            });

            RegisterRoute(app, "GET", "description", (request) =>
            {
                return "M1 Mirror Door Left and Right, Flap M1 and Flap M2";
            });

            RegisterRoute(app, "GET", "name", (request) =>
            {
                return "Telescope Covers";
            });

            RegisterRoute<string[]>(app, "GET", "supportedactions", (request) =>
            {
                return ["fanspeed"];
            });

            RegisterRoute(app, "GET", "driverinfo", (request) =>
            {
                return _plc.hostname;
            });

            RegisterRoute(app, "GET", "interfaceversion", (request) =>
            {
                return 2;
            });



            RegisterRoute<object>(app, "GET", "brightness", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });
            RegisterRoute<object>(app, "GET", "calibratorchanging", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });
            RegisterRoute(app, "GET", "calibratorstate", (request) =>
            {
                return 0; // Not present
            });
            RegisterRoute<object>(app, "GET", "maxbrightness", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });
            RegisterRoute<object>(app, "PUT", "calibratoroff", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });
            RegisterRoute<object>(app, "PUT", "calibratoron", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });







            RegisterRoute(app, "GET", "covermoving", (request) =>
            {
                return getIsCoverMoving();
            });
            RegisterRoute<object>(app, "GET", "coverstate", (request) =>
            {
                return getCoverState();
            });

            RegisterRoute<object>(app, "PUT", "closecover", (request) =>
            {
                bool isAutomaticMode = _plc.GetFlapIsAutomaticMode();
                if (!isAutomaticMode)
                {
                    throw new AlpacaException(0x40b, "Unable to move covers in manual mode. Please use Telesocpe HMI to set to automatic mode");
                }

                _plc.SetFlapState(FlapState.FullyClosed);
                return null;
            });

            RegisterRoute<object>(app, "PUT", "opencover", (request) =>
            {
                bool isAutomaticMode = _plc.GetFlapIsAutomaticMode();
                if (!isAutomaticMode)
                {
                    throw new AlpacaException(0x40b, "Unable to move covers in manual mode. Please use Telesocpe HMI to set to automatic mode");
                }

                _plc.SetFlapState(FlapState.MirrorDoorsAndFlapsOpen);
                return null;
            });

            RegisterRoute<object>(app, "PUT", "haltcover", (request) =>
            {
                throw new PropertyOrMethodNotImplementedException();
            });


            RegisterRoute(app, "GET", "fanspeed", (request) =>
            {
                return _plc.ReadFanSpeed();
            });

            RegisterRoute<object>(app, "PUT", "fanspeed", (request) =>
            {
                int rpm = int.Parse(request.Form["Value"]);
                if (rpm != 0 && (rpm < 900 || rpm > 4000))
                {
                    throw new AlpacaException(0x401, "Fan speed must be 0 (off) or between 900 and 4000 RPM");
                }
                _plc.SetFanSpeed(rpm);
                return null;
            });

            RegisterRoute<StateValue[]>(app, "GET", "devicestate", (request) =>
            {
                return [
                        new StateValue("CoverState",  getCoverState()),
                        new StateValue("CoverMoving", getIsCoverMoving()),
                        new StateValue("FanSpeed", _plc.ReadFanSpeed())
                    ];
            });




        }

        private bool getIsCoverMoving()
        {
            FlapMovingState flapState = _plc.ReadFlapMovingState();
            return flapState.IsMoving;
        }

        private int getCoverState()
        {
            bool isAutomaticMode = _plc.GetFlapIsAutomaticMode();

            FlapMovingState flapMovingState = _plc.ReadFlapMovingState();

            FlapState flapState = _plc.ReadFlapState();


            if (!isAutomaticMode)
            {
                return 4; // Unknown
            }

            if (flapMovingState.IsMoving)
            {
                return 2; // Moving
            }

            if (flapState == FlapState.FullyClosed)
            {
                return 1; // Closed
            }

            if (flapState == FlapState.MirrorDoorsAndFlapsOpen)
            {
                return 3; // Open
            }

            return 5; // Error
        }

    }
}
