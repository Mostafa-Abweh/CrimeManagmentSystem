using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface ILawyerService
    {
        Lawyer Create(Lawyer lawyer);
        Task<List<Lawyer>> GetAll();
        Lawyer Update(Lawyer lawyer);
        bool Delete(int id);
        Task<List<Lawyer>> GetById(int id);
    }
}
