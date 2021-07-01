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
    public class WitnessController : Controller
    {
        private readonly IWitnessService WitnessService;
        public WitnessController(IWitnessService _witnessService)
        {
            this.WitnessService = _witnessService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Witness), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Witness Create([FromBody] Witness witness)
        { return WitnessService.Create(witness); }

        [HttpGet]
        [ProducesResponseType(typeof(List<Witness>), StatusCodes.Status200OK)]
        public List<Witness> GetAll()
        { return WitnessService.GetAll(); }

        [HttpGet("{Id}")]
        public Witness GetById(int id)
        { return WitnessService.GetById(id); }

        [HttpPut]
        [ProducesResponseType(typeof(Witness), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Witness Update([FromBody] Witness witness)
        { return WitnessService.Update(witness); }

        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return WitnessService.Delete(id);
        }
    }
}
