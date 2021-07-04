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
    public class JudgeController : ControllerBase
    {
        private readonly IJudgeService _judgeService;
        public JudgeController(IJudgeService _judgeService)
        {
            this._judgeService = _judgeService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Judge), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Judge Create([FromBody] Judge judge)
        { return _judgeService.Create(judge); }
        [HttpGet]
        [ProducesResponseType(typeof(Task<List<Judge>>), StatusCodes.Status200OK)]
        public Task<List<Judge>> GetAll()
        { return _judgeService.GetAll(); }
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(Task<List<Judge>>), StatusCodes.Status200OK)]
        public Task<List<Judge>> GetById(int id)
        { return _judgeService.GetById(id); }
        [HttpPut]
        [ProducesResponseType(typeof(Judge), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Judge Update([FromBody] Judge judge)
        { return _judgeService.Update(judge); }
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {

            return _judgeService.Delete(id);
        }

        [HttpPost]
        [Route("Search")]
        [ProducesResponseType(typeof(Task<List<Judge>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<List<Judge>> Search([FromBody] JudgeDTO courseDTO)
        { return _judgeService.Search(courseDTO); }
    }
}
