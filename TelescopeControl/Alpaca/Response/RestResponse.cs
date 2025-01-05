using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelescopeControl.Alpaca.Response
{
    public class RestResponse<T>: RestResponseBase
    {
        public T Value { get; set; }

        public RestResponse(T value)
        {
            Value = value;
        }
    }
}
