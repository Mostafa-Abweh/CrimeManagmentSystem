using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IPoliceStationService
    {
        PoliceStation Create(PoliceStation PS);
        Task<List<PoliceStation>> GetAll();
        PoliceStation Update(PoliceStation PS);
        bool Delete(int id);
        Task<List<PoliceStation>> GetById(int id);
    }
}
