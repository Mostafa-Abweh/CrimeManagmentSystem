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
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService _sectionService)
        {
            this._sectionService = _sectionService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Section), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Section Create([FromBody] Section section)
        { return _sectionService.Create(section); }
        [HttpGet]
        [ProducesResponseType(typeof(Task<List<Section>>), StatusCodes.Status200OK)]
        public Task<List<Section>> GetAll()
        { return _sectionService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<Section>>), StatusCodes.Status200OK)]
        public Task<List<Section>> GetById(int id)
        { return _sectionService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Section), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Section Update([FromBody] Section section)
        { return _sectionService.Update(section); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _sectionService.Delete(id);
        }
        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(typeof(Task<List<Section>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<List<Section>> Search([FromBody] SectionDTO courseDTO)
        { return _sectionService.Search(courseDTO); }

    }
}
