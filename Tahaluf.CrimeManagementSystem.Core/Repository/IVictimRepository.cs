using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IVictimRepository
    {
        int Create(Victim victim);
        int Update(Victim victim);
        bool Delete(int id);
        Task<List<Victim>> GetAll();
        Task<List<Victim>> GetById(int id);
        Task<List<Victim>> Search(VictimDTO victimDTO);
    }
}
