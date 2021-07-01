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
    public class WitnessRepository : IWitnessRepository
    {
        private readonly IDBContext _dBContext;
        public WitnessRepository(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(Witness witness)
        {
            var p = new DynamicParameters();

            p.Add("@WitnessId", witness.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", witness.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", witness.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", witness.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Address", witness.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", witness.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", witness.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Contact", witness.Contact, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertWitness", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Witness> GetAll()
        {
            List<Witness> result = (List<Witness>)_dBContext.Connection.Query<Witness>("GetAllWitness", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Witness witness)
        {
            var p = new DynamicParameters();

            p.Add("@WitnessId", witness.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", witness.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MotherName", witness.MotherName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Age", witness.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Address", witness.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", witness.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", witness.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Contact", witness.Contact, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdateWitness", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteWitness", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public Witness GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Witness result = (Witness)_dBContext.Connection.Query<Witness>("GetByIdWitness", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
