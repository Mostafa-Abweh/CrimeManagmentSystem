using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IVictimRepository
    {
        int Create(Victim victim);
        int Update(Victim victim);
        bool Delete(int id);
        List<Victim> GetAll();
        Victim GetById(int id);
        List<Victim> Search(VictimDTO victimDTO);
    }
}
