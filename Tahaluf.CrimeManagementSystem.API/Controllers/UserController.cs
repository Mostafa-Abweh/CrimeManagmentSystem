using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService UserService;
        public UserController(IUserService _userService)
        {
            this.UserService = _userService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public User Create([FromBody] User user)
        { return UserService.Create(user); }

        [HttpGet]
        [ProducesResponseType(typeof(Task<List<User>>), StatusCodes.Status200OK)]
        public Task<List<User>> GetAll()
        { return UserService.GetAll(); }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<User>>), StatusCodes.Status200OK)]
        public Task<List<User>> GetById(int id)
        { return UserService.GetById(id); }

        [HttpPut]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public User Update([FromBody] User user)
        { return UserService.Update(user); }

        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return UserService.Delete(id);
        }

    }
}
