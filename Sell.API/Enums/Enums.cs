namespace Sell.API.Enums
{
    public enum StatusCodeEnum
    {
        OK = 200,
        Created = 201,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        InternalServerError = 500,
        UnprocessableEntity = 422
    }
}
