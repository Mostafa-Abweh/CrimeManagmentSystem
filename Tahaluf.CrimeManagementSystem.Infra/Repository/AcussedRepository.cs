using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
   public class AcussedRepository: IAcussedRepository
    {
        private readonly IDBContext _dBContext;
        public AcussedRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Acussed acussed)
        {
            var p = new DynamicParameters();

            p.Add("@Name", acussed.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", acussed.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", acussed.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", acussed.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Gender", acussed.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", acussed.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeFileNumber", acussed.CrimeFileNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertAcussed", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<Acussed>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<Acussed>("GetAllAcussed", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(Acussed acussed)
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", acussed.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", acussed.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", acussed.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", acussed.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", acussed.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Gender", acussed.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", acussed.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeFileNumber", acussed.CrimeFileNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateAcussed", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteAcussed", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Acussed>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Acussed>("GetByIdAcussed", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<List<Acussed>> Search(AcussedDTO acussedDTO)
        {
            var p = new DynamicParameters();
        
            p.Add("@AcussedName", acussedDTO.AcussedName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", acussedDTO.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeTitle", acussedDTO.CrimeTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Acussed>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
