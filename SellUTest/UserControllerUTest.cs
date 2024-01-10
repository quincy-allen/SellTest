using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Sell.API.Controllers;
using Sell.API.Helpers;
using Sell.API.Requests;
using Sell.Domain.Interfaces.User;
using Sell.Domain.Models;

namespace SellUTest
{
    public class UserControllerUTest
    {
        private readonly Mock<IUserService> _mockService;
        private readonly UserController _userController;
        private readonly IUserService _userService;
        private readonly IResponseHelper _responseHelper;
        private readonly Mock<IMapper> _mapperMock;
        public UserControllerUTest()
        {
            _mockService = new Mock<IUserService>();
            _userController = new UserController(_userService, _responseHelper, _mapperMock.Object);
        }

        [Fact]
        public async Task CreateUsers()
        {
            // Arrange
            var createUserRequest = new UserRequestObject();
            var user = new UserDTO();

            _mockService.Setup(service => service.CreateUser(It.IsAny<UserDTO>())).ReturnsAsync(user);

            // Act
            var result = await _userController.CreateUser(createUserRequest);

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<UserDTO>>>(result);
            var returnValue = Assert.IsType<OkObjectResult>(actionResult.Result);
            Assert.Equal(user, returnValue.Value);
        }

    }
}
