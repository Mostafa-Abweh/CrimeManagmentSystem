using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IPoliceStationRepository
    {
        int Create(PoliceStation PS);
        List<PoliceStation> GetAll();
        int Update(PoliceStation PS);
        bool Delete(int id);
        PoliceStation GetById(int id);
    }
}
