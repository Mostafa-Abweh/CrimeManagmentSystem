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
    public class OfficerController : Controller
    {
        private readonly IOfficerService OfficerService;
        public OfficerController(IOfficerService _officerService)
        {
            this.OfficerService = _officerService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Officer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Officer Create([FromBody] Officer officer)
        { return OfficerService.Create(officer); }

        [HttpGet]
        [ProducesResponseType(typeof(List<Officer>), StatusCodes.Status200OK)]
        public List<Officer> GetAll()
        { return OfficerService.GetAll(); }

        [HttpGet("{Id}")]
        public Officer GetById(int id)
        { return OfficerService.GetById(id); }

        [HttpPut]
        [ProducesResponseType(typeof(Officer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Officer Update([FromBody] Officer officer)
        { return OfficerService.Update(officer); }

        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return OfficerService.Delete(id);
        }
    }
}
