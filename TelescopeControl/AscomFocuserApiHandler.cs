using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            RegisterRoute(app, "GET", "connected", (request) =>
            {
                return _focuser.Enabled;
            });

            RegisterRoute<object>(app, "PUT", "connected", (request) =>
            {
                _focuser.Enabled = bool.Parse(request.Form["Connected"]);
                return null;
            });

            RegisterRoute(app, "GET", "description", (request) =>
            {
                return _focuser.name;
            });

            RegisterRoute(app, "GET", "name", (request) =>
            {
                return _focuser.name;
            });

            RegisterRoute(app, "GET", "driverinfo", (request) =>
            {
                return _focuser.servo.GetType().Name;
            });

            RegisterRoute(app, "GET", "interfaceversion", (request) =>
            {
                return "4";
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
                return (int)(_focuser.maxPosition * 100);
            });

            RegisterRoute(app, "GET", "maxstep", (request) =>
            {
                return (int)(_focuser.maxPosition * 100);
            });

            RegisterRoute(app, "GET", "position", (request) =>
            {
                return (int)(_focuser.currentPosition * 100);
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
                double position = stepPosition / 100.0;
                _ =_focuser.MoveTo(position);
                return null;
            });


        }
    }

}