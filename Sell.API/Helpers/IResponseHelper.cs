using Microsoft.AspNetCore.Mvc;

namespace Sell.API.Helpers
{
    public interface IResponseHelper
    {
        IActionResult ApiResponse<T>(T result) where T : class;
    }
}
