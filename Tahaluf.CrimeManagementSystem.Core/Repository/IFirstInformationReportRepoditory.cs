using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IFirstInformationReportRepoditory
    {
        int Create(FirstInformationReport FIR);
        Task<List<FirstInformationReport>> GetAll();
        int Update(FirstInformationReport FIR);
        bool Delete(int id);
        Task<List<FirstInformationReport>> GetById(int id);
    }
}
