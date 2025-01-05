using System;
using TelescopeControl.Alpaca.Response;

namespace TelescopeControl.Alpaca
{
    public static class AscomResponseHelper
    {

        public static RestResponseBase CreateResponse<T>(uint? clientTransactionID, uint serverTransactionID, T value, int errorNumber = 0, string errorMessage = "", Exception exception = null)
        {
            RestResponseBase response = value != null ? new RestResponse<T>(value) : new EmptyRestResponse();
            response.ClientTransactionID = clientTransactionID ?? 0;
            response.ServerTransactionID = serverTransactionID;
            response.ErrorNumber = errorNumber;
            response.ErrorMessage = errorMessage;

            if (exception != null)
            {
                response.DriverException = exception;
            }

            return response;
        }
    }
}
