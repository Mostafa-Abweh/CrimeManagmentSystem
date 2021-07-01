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
    public class VictimController : ControllerBase
    {

        private readonly IVictimService _victimService;
        public VictimController(IVictimService _victimService)
        {
            this._victimService = _victimService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Victim), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Victim Create([FromBody] Victim victim)
        { return _victimService.Create(victim); }
        [HttpGet]
        [ProducesResponseType(typeof(List<Victim>), StatusCodes.Status200OK)]
        public List<Victim> GetAll()
        { return _victimService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Victim), StatusCodes.Status200OK)]
        public Victim GetById(int id)
        { return _victimService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Victim), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Victim Update([FromBody] Victim victim)
        { return _victimService.Update(victim); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _victimService.Delete(id);
        }
        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(typeof(List<Victim>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Victim> Search([FromBody] VictimDTO victimDTO)
        { return _victimService.Search(victimDTO); }

    }
}
