namespace Demo.Core.DTOs.Request
{
    public class AddAPILogDTO
    {
        public string APIUrl { get; set; }
        public string APIParams { get; set; }
        public string Headers { get; set; }
        public string Method { get; set; }
        public int APILogId { get; set; }
    }
    public class ErrorDetailDTO
    {
        public int keyId { get; set; }
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
    public class UpdateAPILogDTO
    {
        public int APILogId { get; set; }
        public bool Success { get; set; }
        public string ExceptionMsg { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionSource { get; set; }
    }
}