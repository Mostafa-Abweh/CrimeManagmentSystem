using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
  public  class PermissionService: IPermissionService
    {

        private readonly IPermissionRepository _permissionRepository;
        public PermissionService(IPermissionRepository _permissionRepository)
        {
            this._permissionRepository = _permissionRepository;
        }

        public Task<List<Permission>> GetAll()
        {
            return _permissionRepository.GetAll();
        }
        public Permission Update(Permission permission)
        {
            _permissionRepository.Update(permission);
            return permission;
        }
        public Permission Create(Permission permission)
        {
            _permissionRepository.Create(permission);
            return permission;
        }
        public bool Delete(int id)
        {
            return _permissionRepository.Delete(id);
        }
        public Task<List<Permission>> GetById(int id)
        {
            return _permissionRepository.GetById(id);
        }
    }
}
