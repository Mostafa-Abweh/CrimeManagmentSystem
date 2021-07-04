using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IWitnessRepository
    {
        int Create(Witness witness);
        Task<List<Witness>> GetAll();
        int Update(Witness witness);
        bool Delete(int id);
        Task<List<Witness>> GetById(int id);
    }
}
