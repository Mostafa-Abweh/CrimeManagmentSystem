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
    public class PoliceStationRepository : IPoliceStationRepository
    {
        private readonly IDBContext _dBContext;
        public PoliceStationRepository(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(PoliceStation PS)
        {
            var p = new DynamicParameters();

            p.Add("@PoliceStationId", PS.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", PS.PSName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Location", PS.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", PS.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", PS.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", PS.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@NumberOfStuff", PS.NumberOfStuff, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertPoliceStation", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<PoliceStation> GetAll()
        {
            List<PoliceStation> result = (List<PoliceStation>)_dBContext.Connection.Query<PoliceStation>("GetAllPoliceStation", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(PoliceStation PS)
        {
            var p = new DynamicParameters();

            p.Add("@PoliceStationId", PS.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", PS.PSName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Location", PS.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", PS.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Phone", PS.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Notes", PS.Notes, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@NumberOfStuff", PS.NumberOfStuff, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdatePoliceStation", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PoliceStationId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeletePoliceStation", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public PoliceStation GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PoliceStationId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            PoliceStation result = (PoliceStation)_dBContext.Connection.Query<PoliceStation>("GetByIdPoliceStation", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
