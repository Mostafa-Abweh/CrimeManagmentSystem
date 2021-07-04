using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IDBContext _dBContext;
        public RoleRepository(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(Role role)
        {
            var p = new DynamicParameters();

            p.Add("@RoleId", role.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleName", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleDescription", role.RoleDescription, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertRole", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<Role>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<Role>("GetALLRole", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(Role role)
        {
            var p = new DynamicParameters();

            p.Add("@RoleId", role.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleName", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleDescription", role.RoleDescription, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdateRole", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@RoleId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteRole", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Role>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@RoleId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Role>("GetByIdRole", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
