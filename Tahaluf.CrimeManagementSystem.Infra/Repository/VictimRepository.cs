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
  public class VictimRepository: IVictimRepository
    {
        private readonly IDBContext _dBContext;
        public VictimRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Victim victim)
        {
            var p = new DynamicParameters();

            p.Add("@Name", victim.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", victim.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", victim.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Contact", victim.Contact, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", victim.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertVictim", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<Victim>> GetAll()
        {
            var result =  await _dBContext.Connection.QueryAsync<Victim>("GetAllVictim", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(Victim victim)
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", victim.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", victim.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", victim.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", victim.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Contact", victim.Contact, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", victim.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateVictim", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteVictim", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Victim>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           var result = await _dBContext.Connection.QueryAsync<Victim>("GetByIdVictim", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public async Task<List<Victim>> Search(VictimDTO victimDTO)
        {
            var p = new DynamicParameters();
            p.Add("@SectionName", victimDTO.VictimName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SectionName", victimDTO.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeId", victimDTO.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           var result = await _dBContext.Connection.QueryAsync<Victim>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
