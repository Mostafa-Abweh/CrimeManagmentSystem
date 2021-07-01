﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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

            p.Add("@RoleId", permission.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PermissionName", permission.PermissionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PermissionModule", permission.PermissionModule, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertPermission", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Permission> GetAll()
        {
            List<Permission> result = (List<Permission>)_dBContext.Connection.Query<Permission>("GetAllpermission", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Permission permission)
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", permission.PermissionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleId", permission.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PermissionName", permission.PermissionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PermissionModule", permission.PermissionModule, dbType: DbType.Int32, direction: ParameterDirection.Input);
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
        public Permission GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@PermissionId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Permission result = (Permission)_dBContext.Connection.Query<Permission>("GetByIdPermission", p, commandType: CommandType.StoredProcedure);
            return result;
        }

    }
}