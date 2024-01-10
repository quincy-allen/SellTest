using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sell.API.Helpers;
using Sell.API.Requests;
using Sell.Domain.Interfaces.User;
using Sell.Domain.Models;

namespace Sell.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v1.0/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IResponseHelper _responseHelper;
        private readonly IMapper _mapper;
        public UserController(IUserService userService,
            IResponseHelper responseHelper,
            IMapper mapper)
        {
            _userService = userService;
            _responseHelper = responseHelper;
            _mapper = mapper;
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser([FromBody] UserRequestObject userData)
        {
            var userRequestDto = _mapper.Map<UserDTO>(userData);
            var response = await _userService.CreateUser(userRequestDto);
            return _responseHelper.ApiResponse(response);
        }
        [HttpGet("all-users")]
        public async Task<IActionResult> AllUsers()
        {
            var response = await _userService.GetAllUser();
            return _responseHelper.ApiResponse(response);
        }
    }
}
