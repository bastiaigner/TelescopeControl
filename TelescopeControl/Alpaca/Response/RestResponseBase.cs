using System;
using System.Text.Json.Serialization;
using TelescopeControl.Alpaca.Exceptions;

namespace TelescopeControl.Alpaca.Response
{
    public abstract class RestResponseBase
    {
        private Exception _exception;

        [JsonPropertyName("ClientTransactionID")]
        public uint ClientTransactionID { get; set; }

        [JsonPropertyName("ServerTransactionID")]
        public uint ServerTransactionID { get; set; }

        [JsonPropertyName("ErrorNumber")]
        public int ErrorNumber { get; set; } = 0;

        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; } = "";

        [JsonIgnore]
        public Exception DriverException
        {
            get => _exception;
            set
            {
                _exception = value;
                // Carry over errorcode and errormessage from AlpacaExceptions; anything
                // else maps to the Alpaca driver-specific error base so clients never
                // mistake a failure for success.
                if (_exception is AlpacaException exc)
                {
                    ErrorNumber = exc.ErrorCode;
                    ErrorMessage = exc.ErrorMessage;
                }
                else
                {
                    ErrorNumber = 0x500;
                    ErrorMessage = _exception.Message;
                }
            }
        }

        public bool ShouldSerializeDriverException() => SerializeDriverException;

        internal bool SerializeDriverException { get; set; } = true;
    }

    public static class ErrorConstants
    {
        public const int ASCOM_ERROR_NUMBER_BASE = unchecked((int)0x80040400);
        public const int ASCOM_ERROR_NUMBER_MAX = unchecked((int)0x80040FFF);
        public const int ASCOM_ERROR_NUMBER_OFFSET = unchecked((int)0x80040000);
    }
}
