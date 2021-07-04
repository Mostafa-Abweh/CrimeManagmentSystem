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
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService _permissionService)
        {
            this._permissionService = _permissionService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Permission), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Permission Create([FromBody] Permission permission)
        { return _permissionService.Create(permission); }
        [HttpGet]
        [ProducesResponseType(typeof(Task<List<Permission>>), StatusCodes.Status200OK)]
        public Task<List<Permission>> GetAll()
        { return _permissionService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<Permission>>), StatusCodes.Status200OK)]
        public Task<List<Permission>> GetById(int id)
        { return _permissionService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Permission), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Permission Update([FromBody] Permission permission)
        { return _permissionService.Update(permission); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _permissionService.Delete(id);
        }
    }
}
