using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
   public interface ISectionService
    {
        Section Create(Section section);
        Section Update(Section section);
        List<Section> GetAll();
        Section GetById(int id);
        bool Delete(int id);
        List<Section> Search(SectionDTO sectionDTO);
    }
}
