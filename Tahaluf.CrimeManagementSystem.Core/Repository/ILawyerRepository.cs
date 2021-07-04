using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface ILawyerRepository
    {
        int Create(Lawyer lawyer);
        Task<List<Lawyer>> GetAll();
        int Update(Lawyer lawyer);
        bool Delete(int id);
        Task<List<Lawyer>> GetById(int id);
    }
}
