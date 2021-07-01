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
    public class LawyerRepository : ILawyerRepository
    {
        private readonly IDBContext _dBContext;
        public LawyerRepository(IDBContext _dBContext) 
        { this._dBContext = _dBContext; }
        public int Create(Lawyer lawyer)
        {
            var p = new DynamicParameters();

            p.Add("@LawyerId", lawyer.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", lawyer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", lawyer.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", lawyer.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", lawyer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", lawyer.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", lawyer.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", lawyer.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", lawyer.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", lawyer.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Descriptopn", lawyer.Descriptopn, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Qualification", lawyer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            
            var result = _dBContext.Connection.ExecuteAsync("InsertLawyer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Lawyer> GetAll()
        {
            List<Lawyer> result = (List<Lawyer>)_dBContext.Connection.Query<Lawyer>("GetAllLawyer", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Lawyer lawyer)
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", lawyer.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", lawyer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", lawyer.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", lawyer.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", lawyer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HomePhone", lawyer.HomePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CellPhone", lawyer.CellPhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@OfficePhone", lawyer.OfficePhone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", lawyer.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfHire", lawyer.DateOfHire, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Descriptopn", lawyer.Descriptopn, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Qualification", lawyer.Qualification, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateLawyer", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteLawyer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public Lawyer GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Lawyer result = (Lawyer)_dBContext.Connection.Query<Lawyer>("GetByIdLawyer", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
