using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcussedController : ControllerBase
    {
        private readonly IAcussedService _acussedService;
        public AcussedController(IAcussedService _acussedService)
        {
            this._acussedService = _acussedService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Acussed), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Acussed Create([FromBody] Acussed acussed)
        { return _acussedService.Create(acussed); }
        [HttpGet]
        [ProducesResponseType(typeof(List<Acussed>), StatusCodes.Status200OK)]
        public List<Acussed> GetAll()
        { return _acussedService.GetAll(); }
        [HttpGet("{Id}")]

        public Acussed GetById(int id)
        { return _acussedService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Acussed), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Acussed Update([FromBody] Acussed acussed)
        { return _acussedService.Update(acussed); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _acussedService.Delete(id);
        }

        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(typeof(List<Acussed>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Acussed> Search([FromBody] AcussedDTO acussedDTO)
        { return _acussedService.Search(acussedDTO); }
    }
}
