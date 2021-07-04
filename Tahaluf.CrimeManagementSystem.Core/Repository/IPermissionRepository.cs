using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IPermissionRepository
    {
        int Create(Permission permission);
        int Update(Permission permission);
        bool Delete(int id);
        Task<List<Permission>> GetAll();
        Task<List<Permission>> GetById(int id);
    }
}
