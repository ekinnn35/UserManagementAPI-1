using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.DTO;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto dto)
        {
            var user = await _userService.RegisterUserAsync(dto);
            return Ok(new {user.Id, user.Email });
        }
    }
}
