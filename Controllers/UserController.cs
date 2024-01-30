using MaranntaApi.Application.Interfaces;
using MaranntaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaranntaApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersCrontroller : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersCrontroller(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<User> getUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpPost]
        [Route("")]
        public ActionResult<User> createUser([FromBody] User user)
        {
            return _userService.Create(user);
        }
    }
}
