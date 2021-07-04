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
    public class RoleController : Controller
    {
        public class LawyerController : Controller
        {
            private readonly IRoleService RoleService;
            public LawyerController(IRoleService _roleService)
            {
                this.RoleService = _roleService;
            }

            [HttpPost]
            [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public Role Create([FromBody] Role role)
            { return RoleService.Create(role); }

            [HttpGet]
            [ProducesResponseType(typeof(Task<List<Role>>), StatusCodes.Status200OK)]
            public Task<List<Role>> GetAll()
            { return RoleService.GetAll(); }

            [HttpGet("{Id}")]
            [ProducesResponseType(typeof(Task<List<Role>>), StatusCodes.Status200OK)]
            public Task<List<Role>> GetById(int id)
            { return RoleService.GetById(id); }

            [HttpPut]
            [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public Role Update([FromBody] Role role)
            { return RoleService.Update(role); }

            [HttpDelete("{Id}")]
            public bool Delete(int id)
            {
                return RoleService.Delete(id);
            }
        }
    }
}
