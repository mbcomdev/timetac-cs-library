namespace TimeTac_Library.Utils
{
    public class ApiResponseModel<T>
    {
        public bool Success { get; set; }
        public int? NumResults { get; set; }
        public T Results { get; set; }
        public string RequestStartTime { get; set; }
        public string ErrorMessage { get; set; }
        public ExtendedError ErrorExtended { get; set; }
        public string ErrorInternal { get; set; }

    }

    public class ExtendedError
    {
        public object aErrorTranslationConstants { get; set; }
        public object Data { get; set; }
        public string ErrorString { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorBaseString { get; set; }
    }
}
