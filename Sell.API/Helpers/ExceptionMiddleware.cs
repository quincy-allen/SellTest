using Newtonsoft.Json;
using Sell.API.Enums;

namespace Sell.API.Helpers
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            var statusCode = exception switch
            {
                CustomNotFoundException => (int)StatusCodeEnum.NotFound,
                CustomValidationException => (int)StatusCodeEnum.BadRequest,
                CustomUnauthorizedException => (int)StatusCodeEnum.Unauthorized,
                // ... add other custom exceptions here
                _ => (int)StatusCodeEnum.InternalServerError,
            };

            context.Response.StatusCode = statusCode;

            var result = JsonConvert.SerializeObject(new
            {
                statusCode = statusCode,
                message = GetErrorMessage(statusCode, exception)
            });

            return context.Response.WriteAsync(result);
        }

        private string GetErrorMessage(int statusCode, Exception exception)
        {
            bool isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
            return statusCode == (int)StatusCodeEnum.InternalServerError && !isDevelopment
                ? "An unexpected error occurred."
                : exception.Message;
        }
    }

    // Define other custom exception classes as needed...
    public class CustomNotFoundException : Exception
    {
        public CustomNotFoundException(string message) : base(message) { }
    }

    public class CustomValidationException : Exception
    {
        public CustomValidationException(string message) : base(message) { }
    }

    public class CustomUnauthorizedException : Exception
    {
        public CustomUnauthorizedException(string message) : base(message) { }
    }

}
