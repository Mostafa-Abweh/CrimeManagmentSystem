using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
 public interface IVictimService
    {

        Victim Create(Victim victim);
        Victim Update(Victim victim);
        Task<List<Victim>> GetAll();
        Task<List<Victim>> GetById(int id);
        bool Delete(int id);
        Task<List<Victim>> Search(VictimDTO victimDTO);
    }
}
