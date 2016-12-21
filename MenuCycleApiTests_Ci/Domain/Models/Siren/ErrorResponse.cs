using System;
using System.Net;

namespace MenuCycleApiTests_ci.Domain.Model
{
    public class ErrorResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public string exceptionMessage { get; set; }
        public string exceptionType { get; set; }
        public string stackTrace { get; set; }
        public string ErrorCode { get; set; }
        public string Location { get; set; }
        public Uri HelpUrl { get; set; }
    }
}
