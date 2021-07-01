using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IFirstInformationReportRepoditory
    {
        int Create(FirstInformationReport FIR);
        List<FirstInformationReport> GetAll();
        int Update(FirstInformationReport FIR);
        bool Delete(int id);
        FirstInformationReport GetById(int id);
    }
}
