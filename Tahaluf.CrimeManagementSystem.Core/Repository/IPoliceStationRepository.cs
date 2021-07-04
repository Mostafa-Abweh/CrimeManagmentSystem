using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IPoliceStationRepository
    {
        int Create(PoliceStation PS);
        Task<List<PoliceStation>> GetAll();
        int Update(PoliceStation PS);
        bool Delete(int id);
        Task<List<PoliceStation>> GetById(int id);
    }
}
