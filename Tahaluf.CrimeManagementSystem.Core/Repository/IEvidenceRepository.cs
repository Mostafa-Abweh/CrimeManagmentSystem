using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IEvidenceRepository
    {
        int Create(Evidence evidence);
        int Update(Evidence evidence);
        bool Delete(int id);
        Task<List<Evidence>> GetAll();
        Task<List<Evidence>> GetById(int id);
    }
}
