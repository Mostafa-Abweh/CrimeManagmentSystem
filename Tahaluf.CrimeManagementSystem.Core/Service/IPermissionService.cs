using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IPermissionService
    {
        Permission Create(Permission permission);
        Permission Update(Permission permission);
        Task<List<Permission>> GetAll();
        Task<List<Permission>> GetById(int id);
        bool Delete(int id);
    }
}
