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
    public class FirstInformationReportController : Controller
    {
        private readonly IFirstInformationReportService FIRService;
        public FirstInformationReportController(IFirstInformationReportService _fIRService)
        {
            this.FIRService = _fIRService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(FirstInformationReport), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FirstInformationReport Create([FromBody] FirstInformationReport FIR)
        { return FIRService.Create(FIR); }

        [HttpGet]
        [ProducesResponseType(typeof(Task<List<FirstInformationReport>>), StatusCodes.Status200OK)]
        public Task<List<FirstInformationReport>> GetAll()
        { return FIRService.GetAll(); }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<FirstInformationReport>>), StatusCodes.Status200OK)]
        public Task<List<FirstInformationReport>> GetById(int id)
        { return FIRService.GetById(id); }

        [HttpPut]
        [ProducesResponseType(typeof(FirstInformationReport), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FirstInformationReport Update([FromBody] FirstInformationReport FIR)
        { return FIRService.Update(FIR); }

        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return FIRService.Delete(id);
        }
    }
}
