using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class FirstInformationReportService : IFirstInformationReportService
    {
        private readonly IFirstInformationReportRepoditory FIRRepoditory;
        public FirstInformationReportService(IFirstInformationReportRepoditory _fIRRepoditory)
        {
            this.FIRRepoditory = _fIRRepoditory;
        }

        public List<FirstInformationReport> GetAll()
        {
            return FIRRepoditory.GetAll();
        }
        public FirstInformationReport Update(FirstInformationReport FIR)
        {
            FIRRepoditory.Update(FIR);
            return FIR;
        }
        public FirstInformationReport Create(FirstInformationReport FIR)
        {
            FIRRepoditory.Create(FIR);
            return FIR;
        }
        public bool Delete(int id)
        {
            return FIRRepoditory.Delete(id);
        }
        public FirstInformationReport GetById(int id)
        {
            return FIRRepoditory.GetById(id);
        }
    }
}
