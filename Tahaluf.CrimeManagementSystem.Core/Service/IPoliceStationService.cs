using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IPoliceStationService
    {
        PoliceStation Create(PoliceStation PS);
        List<PoliceStation> GetAll();
        PoliceStation Update(PoliceStation PS);
        bool Delete(int id);
        PoliceStation GetById(int id);
    }
}
