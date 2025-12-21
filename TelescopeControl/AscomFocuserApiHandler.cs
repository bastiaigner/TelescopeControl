using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace TelescopeControl
{
    internal class AscomFocuserApiHandler : AscomDeviceApiHandler
    {

        private AbsoluteFocuser _focuser;

        public AscomFocuserApiHandler(int deviceNumber, AbsoluteFocuser focuser) : base("focuser", deviceNumber)
        {
            _focuser = focuser;
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
                return _focuser.Enabled;
            });

            RegisterRoute<object>(app, "PUT", "connected", (request) =>
            {
                _focuser.Enabled = bool.Parse(request.Form["Connected"]);
                return null;
            });

            RegisterRoute<object>(app, "PUT", "connect", (request) =>
            {
                _focuser.Enabled = true;
                return null;
            });

            RegisterRoute<object>(app, "PUT", "disconnect", (request) =>
            {
                _focuser.Enabled = false;
                return null;
            });

            RegisterRoute(app, "GET", "connecting", (request) =>
            {
                // In our case, connecting is a synchronous operation...
                return false;
            });

            RegisterRoute(app, "GET", "description", (request) =>
            {
                return _focuser.name;
            });

            RegisterRoute(app, "GET", "name", (request) =>
            {
                return _focuser.name;
            });

            RegisterRoute<string[]>(app, "GET", "supportedactions", (request) =>
            {
                return ["calibrate-temperature", "compensate-temperature"];
            });

            RegisterRoute(app, "GET", "driverinfo", (request) =>
            {
                return _focuser.servo.GetType().Name;
            });

            RegisterRoute(app, "GET", "interfaceversion", (request) =>
            {
                return 4;
            });

            RegisterRoute<StateValue[]>(app, "GET", "devicestate", (request) =>
            {
                return [
                        new StateValue("IsMoving",  _focuser.isMoving),
                        new StateValue("Position", focuserToAscomValue(_focuser.currentPosition)),
                        new StateValue("Temperature", _focuser.currentTemperature)
                    ];
            });

            RegisterRoute(app, "GET", "absolute", (request) =>
            {
                return true;
            });

            RegisterRoute(app, "GET", "ismoving", (request) =>
            {
                return _focuser.isMoving;
            });

            RegisterRoute(app, "GET", "maxincrement", (request) =>
            {
                return focuserToAscomValue(_focuser.maxPosition);
            });

            RegisterRoute(app, "GET", "maxstep", (request) =>
            {
                return focuserToAscomValue(_focuser.maxPosition);
            });

            RegisterRoute(app, "GET", "position", (request) =>
            {
                return focuserToAscomValue(_focuser.currentPosition);
            });

            RegisterRoute(app, "GET", "stepsize", (request) =>
            {
                return 1;
            });

            RegisterRoute(app, "GET", "tempcomp", (request) =>
            {
                return _focuser.continuousTemperatureCompensation;
            });

            RegisterRoute<object>(app, "PUT", "tempcomp", (request) =>
            {
                _focuser.continuousTemperatureCompensation = bool.Parse(request.Form["TempComp"]);
                return null;
            });

            RegisterRoute(app, "GET", "tempcompavailable", (request) =>
            {
                return true;
            });

            RegisterRoute(app, "GET", "temperature", (request) =>
            {
                return _focuser.currentTemperature;
            });

            RegisterRoute<object>(app, "PUT", "halt", (request) =>
            {
                _focuser.Halt();
                return null;
            });

            RegisterRoute<object>(app, "PUT", "move", (request) =>
            {
                int stepPosition = int.Parse(request.Form["Position"]);
                double position = ascomToFocuserValue(stepPosition);
                _ = _focuser.MoveTo(position);
                return null;
            });

            RegisterRoute<object>(app, "PUT", "action", (request) =>
            {
                string actionName = request.Form["Action"];
                if (actionName == "calibrate-temperature")
                {
                    _focuser.CalibrateTemperature();
                }
                else if (actionName == "compensate-temperature")
                {
                    _focuser.MoveToCompensateTemperature();
                }
                else
                {
                    throw new InvalidOperationException("Unknown action: " + actionName);
                }
                return null;
            });

        }

        private int focuserToAscomValue(double position)
        {
            return (int)Math.Round(position * 100.0);
        }

        private double ascomToFocuserValue(int position)
        {
            return (double)(position / 100.0m);
        }


    }

    public class StateValue
    {
        [JsonInclude]
        [JsonPropertyName("Name")]
        public string Name;

        [JsonInclude]
        [JsonPropertyName("Value")]
        public object Value;

        public StateValue(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }

}