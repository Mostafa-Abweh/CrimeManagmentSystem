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
    public class LawyerController : Controller
    {
        private readonly ILawyerService LawyerService;
        public LawyerController(ILawyerService _lawyerService)
        {
            this.LawyerService = _lawyerService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Lawyer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Lawyer Create([FromBody] Lawyer lawyer)
        { return LawyerService.Create(lawyer); }
        
        [HttpGet]
        [ProducesResponseType(typeof(List<Lawyer>), StatusCodes.Status200OK)]
        public List<Lawyer> GetAll()
        { return LawyerService.GetAll(); }

        [HttpGet("{Id}")]
        public Lawyer GetById(int id)
        { return LawyerService.GetById(id); }
        
        [HttpPut]
        [ProducesResponseType(typeof(Lawyer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Lawyer Update([FromBody] Lawyer lawyer)
        { return LawyerService.Update(lawyer); }
        
        [HttpDelete("{Id}")]
        public bool Delete(int id)
        {
            return LawyerService.Delete(id);
        }
    }
}
