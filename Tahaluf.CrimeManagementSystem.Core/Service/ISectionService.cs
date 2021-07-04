using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
   public interface ISectionService
    {
        Section Create(Section section);
        Section Update(Section section);
        Task<List<Section>> GetAll();
        Task<List<Section>> GetById(int id);
        bool Delete(int id);
        Task<List<Section>> Search(SectionDTO sectionDTO);
    }
}
