using Sell.API.Enums;

namespace Sell.API
{
    public class Result<T> where T : class
    {
        public Result(
            bool isSuccessful,
            string message,
            T returnedObject,
            StatusCodeEnum returnedCode)
        {
            IsSuccessful = isSuccessful;
            Message = message;
            ReturnedObject = returnedObject;
            ReturnedCode = returnedCode;
        }

        public Result(bool isSuccessful, string message, StatusCodeEnum returnedCode)
        {
            IsSuccessful = isSuccessful;
            Message = message;
            ReturnedCode = returnedCode;
        }

        public Result(bool isSuccessful)
        {
            IsSuccessful = isSuccessful;
        }

        public bool IsSuccessful;
        public string Message;
        public T ReturnedObject;
        public StatusCodeEnum ReturnedCode;
    }
}
