using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
    public class FirstInformationReportRepoditory : IFirstInformationReportRepoditory
    {
        private readonly IDBContext _dBContext;
        public FirstInformationReportRepoditory(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(FirstInformationReport FIR)
        {
            var p = new DynamicParameters();

            p.Add("@FIRId", FIR.FIRId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@FIRName", FIR.FIRName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriotion", FIR.Descriotion, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Type", FIR.Type, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertFIR", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<FirstInformationReport> GetAll()
        {
            List<FirstInformationReport> result = (List<FirstInformationReport>)_dBContext.Connection.Query<FirstInformationReport>("GetAllFIR", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(FirstInformationReport FIR)
        {
            var p = new DynamicParameters();

            p.Add("@FIRId", FIR.FIRId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@FIRName", FIR.FIRName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriotion", FIR.Descriotion, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Type", FIR.Type, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdateFIR", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@FIRId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteFIR", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public FirstInformationReport GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@FIRId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            FirstInformationReport result = (FirstInformationReport)_dBContext.Connection.Query<FirstInformationReport>("GetByIdFIR", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
