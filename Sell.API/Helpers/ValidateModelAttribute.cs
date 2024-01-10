using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sell.API.Enums;

namespace Sell.API.Helpers
{
    public class ValidateModelAttribute : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is BadRequestObjectResult badRequestObjectResult)
                if (badRequestObjectResult.Value is ValidationProblemDetails)
                {
                    var errMessage = string.Join(" | ", context.ModelState.Values
                                                           .SelectMany(v => v.Errors)
                                                           .Select(e => e.ErrorMessage));

                    var executionResponse = new Result<object>(false, errMessage, StatusCodeEnum.BadRequest);

                    var json = JsonConvert.SerializeObject(executionResponse);
                    context.Result = new ContentResult
                    {
                        Content = json,
                        StatusCode = StatusCodes.Status400BadRequest,
                        ContentType = "application/json"
                    };
                }
        }
    }
}
