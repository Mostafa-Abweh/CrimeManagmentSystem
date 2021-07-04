using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IEvidenceService
    {
        Evidence Create(Evidence evidence);
        Evidence Update(Evidence evidence);
        Task<List<Evidence>> GetAll();
        Task<List<Evidence>> GetById(int id);
        bool Delete(int id);
    }
}
