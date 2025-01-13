using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl.Alpaca.Exceptions
{
    public class AlpacaException: Exception
    {
        public int ErrorCode;
        public string ErrorMessage;
        public AlpacaException(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
    }
}
