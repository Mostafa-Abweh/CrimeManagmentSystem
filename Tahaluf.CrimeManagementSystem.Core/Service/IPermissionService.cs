using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IPermissionService
    {
        Permission Create(Permission permission);
        Permission Update(Permission permission);
        List<Permission> GetAll();
        Permission GetById(int id);
        bool Delete(int id);
    }
}
