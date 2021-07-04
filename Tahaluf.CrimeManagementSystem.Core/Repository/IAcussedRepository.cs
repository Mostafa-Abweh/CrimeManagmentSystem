using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IAcussedRepository
    {
        int Create(Acussed acussed);
        int Update(Acussed acussed);
        bool Delete(int id);
        Task<List<Acussed>> GetAll();
        Task<List<Acussed>> GetById(int id);

        Task<List<Acussed>> Search(AcussedDTO acussedDTO);
    }
}
