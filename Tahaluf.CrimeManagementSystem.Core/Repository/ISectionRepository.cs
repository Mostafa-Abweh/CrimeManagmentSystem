using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface ISectionRepository
    {
        int Create(Section section);
        int Update(Section section);
        bool Delete(int id);
        List<Section> GetAll();
        Section GetById(int id);

        List<Section> Search(SectionDTO sectionDTO);
    }
}
