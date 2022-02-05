using System.Net;

namespace Freepay.Models
{
    public class APIResponse<T>
    {

        public T Response { get; set; }
        public APIError Error { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode ResponseCode { get; set; }

        public APIResponse(APIError error, HttpStatusCode responseCode)
        {
            Success = false;
            Error = error;
            ResponseCode = responseCode;
        }

        public APIResponse(T response)
        {
            Success = true;
            Response = response;
        }

        public APIResponse(T response, HttpStatusCode responseCode)
        {
            Success = true;
            Response = response;
            ResponseCode = responseCode;
        }
    }

    public class APIResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public APIError Error { get; set; }

        public APIResponse(APIError error, HttpStatusCode responseCode)
        {
            Success = false;
            Error = error;
            ResponseCode = responseCode;
        }

        public APIResponse(bool success, HttpStatusCode responseCode)
        {
            Success = success;
            ResponseCode = responseCode;
        }

        public APIResponse(bool success)
        {
            Success = success;
        }
    }
}
