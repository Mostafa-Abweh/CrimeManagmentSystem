using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IEvidenceRepository
    {
        int Create(Evidence evidence);
        int Update(Evidence evidence);
        bool Delete(int id);
        List<Evidence> GetAll();
        Evidence GetById(int id);
    }
}
