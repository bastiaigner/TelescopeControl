using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl
{
    public interface IAbsoluteServo
    {
        double minPosition { get; }
        double maxPosition { get; }
        double currentPosition { get; }
        bool isMoving { get; }

        Task MoveTo(double position);
        void Halt();
        bool Enabled { get; set; }

    }
}
