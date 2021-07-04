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
    public class CrimeController : ControllerBase
    {
        private readonly ICrimeService _crimeService;
        public CrimeController(ICrimeService _crimeService)
        {
            this._crimeService = _crimeService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Crime), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Crime Create([FromBody] Crime crime)
        { return _crimeService.Create(crime); }
        [HttpGet]
        [ProducesResponseType(typeof(Task<List<Crime>>), StatusCodes.Status200OK)]
        public Task<List<Crime>> GetAll()
        { return _crimeService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<Crime>>), StatusCodes.Status200OK)]
        public Task<List<Crime>> GetById(int id)
        { return _crimeService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Crime), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Crime Update([FromBody] Crime crime)
        { return _crimeService.Update(crime); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _crimeService.Delete(id);
        }
        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(typeof(Task<List<Crime>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<List<Crime>> Search([FromBody] CrimeDTO crimeDTO)
        { return _crimeService.Search(crimeDTO); }
    }
}
