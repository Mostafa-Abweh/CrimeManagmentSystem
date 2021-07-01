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
    public class OfficerRepository : IOfficerRepository
    {
        private readonly IDBContext _dBContext;
        public OfficerRepository(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(Officer officer)
        {
            var p = new DynamicParameters();

            p.Add("@OfficerId", officer.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", officer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", officer.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", officer.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Badgenumber", officer.Badgenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", officer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", officer.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", officer.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", officer.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Emaill", officer.Emaill, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", officer.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", officer.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Qualification", officer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptopn", officer.Descriptopn, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertOfficer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Officer> GetAll()
        {
            List<Officer> result = (List<Officer>)_dBContext.Connection.Query<Officer>("GetAllOfficer", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Officer officer)
        {
            var p = new DynamicParameters();

            p.Add("@OfficerId", officer.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", officer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", officer.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", officer.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Badgenumber", officer.Badgenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", officer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", officer.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", officer.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", officer.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Emaill", officer.Emaill, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", officer.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", officer.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Qualification", officer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptopn", officer.Descriptopn, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdateOfficer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@OfficerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteOfficer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public Officer GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@OfficerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Officer result = (Officer)_dBContext.Connection.Query<Officer>("GetByIdOfficer", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
