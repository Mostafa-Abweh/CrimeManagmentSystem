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
  public  class PermissonRepository: IPermissionRepository
    {
        private readonly IDBContext _dBContext;
        public PermissonRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Permission permission)
        {
            var p = new DynamicParameters();

            
            p.Add("@PermissionName", permission.PermissionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PermissionDescription", permission.PermissionDescription, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertPermission", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<Permission>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<Permission>("GetAllpermission", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(Permission permission)
        {
            var p = new DynamicParameters();
            p.Add("@PermissionId", permission.PermissionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PermissionName", permission.PermissionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PermissionDescription", permission.PermissionDescription, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("Updatepermission", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PermissionId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeletePermission", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Permission>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PermissionId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Permission>("GetByIdPermission", p, commandType: CommandType.StoredProcedure);
            return result.ToList() ;
        }


    }
}
