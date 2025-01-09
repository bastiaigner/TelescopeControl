using System;
using System.Text.Json.Serialization;

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
                if (_exception != null)
                {
                    ErrorNumber = _exception.HResult;
                    ErrorMessage = _exception.Message;

                    if (ErrorNumber >= ErrorConstants.ASCOM_ERROR_NUMBER_BASE &&
                        ErrorNumber <= ErrorConstants.ASCOM_ERROR_NUMBER_MAX)
                    {
                        ErrorNumber -= ErrorConstants.ASCOM_ERROR_NUMBER_OFFSET;
                    }
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
