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
  public  class JudgeRepository : IJudgeRepository
    {
        private readonly IDBContext _dBContext;
        public JudgeRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Judge judge)
        {
            var p = new DynamicParameters();

            p.Add("@Name", judge.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", judge.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", judge.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", judge.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", judge.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", judge.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", judge.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", judge.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", judge.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", judge.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", judge.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Qualification", judge.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", judge.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertJudge", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<Judge>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<Judge>("GetAllJudge", commandType: CommandType.StoredProcedure);
           
            return result.ToList();
        }
        public int Update(Judge judge)
        {
            var p = new DynamicParameters();
            p.Add("@judgeId", judge.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", judge.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", judge.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", judge.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", judge.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", judge.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", judge.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", judge.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", judge.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", judge.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", judge.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", judge.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Qualification", judge.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Gender", judge.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateJudge", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@JudgeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteJudge", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Judge>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@JudgeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result =await _dBContext.Connection.QueryAsync<Judge>("GetByIdJudge",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<List<Judge>> Search(JudgeDTO judgeDTO)
        {
            var p = new DynamicParameters();
            if (judgeDTO.DateFrom == null && judgeDTO.DateTo != null)
            {
                judgeDTO.DateFrom = judgeDTO.DateTo;
            }
            else if (judgeDTO.DateFrom != null && judgeDTO.DateTo == null)
            {
                judgeDTO.DateTo = DateTime.Now;
            }
            p.Add("@JudgeName", judgeDTO.JudgeName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateFrom", judgeDTO.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateTo", judgeDTO.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@CrimeTitle", judgeDTO.CrimeTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Judge>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
