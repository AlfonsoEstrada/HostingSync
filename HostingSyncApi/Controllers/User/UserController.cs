using Domain.Entities.User.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.IService.User;

namespace HostingSyncApi.Controllers.User
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;            
        }

        [HttpPost]
        public async Task<IActionResult> UserView(UserDto id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Datos faltantes");
            } 

            var response = await _userService.CreateUser(id);

            return Ok(response);
        }

    }
}
