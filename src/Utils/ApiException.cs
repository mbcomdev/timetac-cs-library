using System;

namespace TimeTac_Libary.Utils
{
    public class ApiException : Exception
    {
        public ApiException() : base() { }
        public ApiException(string? message) : base(message) { }
        public ApiException(string? message, Exception? innerException) : base(message, innerException) { }
        public ApiException(string message, ExtendedError extendedError, string internalError) : base(message)
        {
            ErrorExtended = extendedError;
            ErrorInternal = internalError;
        }
        public ExtendedError? ErrorExtended { get; set; }
        public string ErrorInternal { get; set; }
    }
}
