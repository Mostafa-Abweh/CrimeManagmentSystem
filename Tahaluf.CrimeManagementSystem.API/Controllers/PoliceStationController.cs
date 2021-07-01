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
    public class PoliceStationController : Controller
    {
        private readonly IPoliceStationService PSService;
        public PoliceStationController(IPoliceStationService _pSService)
        {
            this.PSService = _pSService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PoliceStation), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public PoliceStation Create([FromBody] PoliceStation PS)
        { return PSService.Create(PS); }

        [HttpGet]
        [ProducesResponseType(typeof(List<PoliceStation>), StatusCodes.Status200OK)]
        public List<PoliceStation> GetAll()
        { return PSService.GetAll(); }

        [HttpGet("{Id}")]
        public PoliceStation GetById(int id)
        { return PSService.GetById(id); }

        [HttpPut]
        [ProducesResponseType(typeof(PoliceStation), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public PoliceStation Update([FromBody] PoliceStation PS)
        { return PSService.Update(PS); }

        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return PSService.Delete(id);
        }
    }
}
