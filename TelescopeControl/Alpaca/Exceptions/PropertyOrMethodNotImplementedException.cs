using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl.Alpaca.Exceptions
{
    public class PropertyOrMethodNotImplementedException : AlpacaException
    {
        public PropertyOrMethodNotImplementedException() : base(0x400, "Property or Method not implemented") { }
    }
}
