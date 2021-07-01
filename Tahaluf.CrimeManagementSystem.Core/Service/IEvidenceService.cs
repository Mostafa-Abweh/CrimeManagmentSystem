using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IEvidenceService
    {
        Evidence Create(Evidence evidence);
        Evidence Update(Evidence evidence);
        List<Evidence> GetAll();
        Evidence GetById(int id);
        bool Delete(int id);
    }
}
