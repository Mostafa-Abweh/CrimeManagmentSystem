using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IPermissionRepository
    {
        int Create(Permission permission);
        int Update(Permission permission);
        bool Delete(int id);
        List<Permission> GetAll();
        Permission GetById(int id);
    }
}
