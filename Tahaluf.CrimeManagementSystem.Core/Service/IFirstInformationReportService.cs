using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IFirstInformationReportService
    {
        FirstInformationReport Create(FirstInformationReport FIR);
        List<FirstInformationReport> GetAll();
        FirstInformationReport Update(FirstInformationReport FIR);
        bool Delete(int id);
        FirstInformationReport GetById(int id);
    }
}
