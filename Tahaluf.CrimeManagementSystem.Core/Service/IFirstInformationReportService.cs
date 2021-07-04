using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IFirstInformationReportService
    {
        FirstInformationReport Create(FirstInformationReport FIR);
        Task<List<FirstInformationReport>> GetAll();
        FirstInformationReport Update(FirstInformationReport FIR);
        bool Delete(int id);
        Task<List<FirstInformationReport>> GetById(int id);
    }
}
