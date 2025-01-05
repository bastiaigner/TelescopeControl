using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl
{
    public interface IFocuserTemperatureSource
    {
        double temperature { get; }
    }
}
