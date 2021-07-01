using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
 public interface IVictimService
    {

        Victim Create(Victim victim);
        Victim Update(Victim victim);
        List<Victim> GetAll();
        Victim GetById(int id);
        bool Delete(int id);
        List<Victim> Search(VictimDTO victimDTO);
    }
}
