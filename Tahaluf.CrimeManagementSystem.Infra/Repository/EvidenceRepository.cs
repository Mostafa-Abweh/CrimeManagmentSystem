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
   public class EvidenceRepository :IEvidenceRepository
    {
        private readonly IDBContext _dBContext;
        public EvidenceRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Evidence evidence)
        {
            var p = new DynamicParameters();

            p.Add("@Description", evidence.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", evidence.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertEvidence", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Evidence> GetAll()
        {
            List<Evidence> result = (List<Evidence>)_dBContext.Connection.Query<Evidence>("GetAllEvidence", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Evidence evidence)
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceIdId", evidence.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Description", evidence.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", evidence.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateEvidence", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteEvidence", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public Evidence GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Evidence result = (Evidence)_dBContext.Connection.Query<Evidence>("GetByIdEvidence", p, commandType: CommandType.StoredProcedure);
            return result;
        }

    }
}
