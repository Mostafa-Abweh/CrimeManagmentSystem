using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface ISectionRepository
    {
        int Create(Section section);
        int Update(Section section);
        bool Delete(int id);
        Task<List<Section>> GetAll();
        Task<List<Section>> GetById(int id);

        Task<List<Section>> Search(SectionDTO sectionDTO);
    }
}
