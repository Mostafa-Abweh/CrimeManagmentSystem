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
    public class EvidenceController : ControllerBase
    {
        private readonly IEvidenceService _evidenceService;
        public EvidenceController(IEvidenceService _evidenceService)
        {
            this._evidenceService = _evidenceService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Evidence), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Evidence Create([FromBody] Evidence evidence)
        { return _evidenceService.Create(evidence); }
        [HttpGet]
        [ProducesResponseType(typeof(List<Evidence>), StatusCodes.Status200OK)]
        public List<Evidence> GetAll()
        { return _evidenceService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Evidence), StatusCodes.Status200OK)]
        public Evidence GetById(int id)
        { return _evidenceService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Evidence), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Evidence Update([FromBody] Evidence evidence)
        { return _evidenceService.Update(evidence); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _evidenceService.Delete(id);
        }
    }
}
