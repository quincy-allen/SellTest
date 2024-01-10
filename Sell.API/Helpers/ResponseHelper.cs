using Microsoft.AspNetCore.Mvc;

namespace Sell.API.Helpers
{
    public class ResponseHelper : ControllerBase, IResponseHelper
    {
        public IActionResult ApiResponse<T>(T result) where T : class
        {
            if (result == null)
            {
                return BadRequest(new { IsSuccessful = false, Message = "Invalid Request", ReturnedObject = (object)null, ReturnedCode = 400 });
            }

            return Ok(new { IsSuccessful = true, Message = "Success", ReturnedObject = result, ReturnedCode = 200 });
        }

    }
}
