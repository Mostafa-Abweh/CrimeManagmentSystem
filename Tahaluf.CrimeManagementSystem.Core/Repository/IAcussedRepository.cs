using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IAcussedRepository
    {
        int Create(Acussed acussed);
        int Update(Acussed acussed);
        bool Delete(int id);
        List<Acussed> GetAll();
        Acussed GetById(int id);

        List<Acussed> Search(AcussedDTO acussedDTO);
    }
}
