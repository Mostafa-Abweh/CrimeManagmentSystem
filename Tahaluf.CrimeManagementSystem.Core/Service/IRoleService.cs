using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IRoleService
    {
        Role Create(Role role);
        List<Role> GetAll();
        Role Update(Role role);
        bool Delete(int id);
        Role GetById(int id);
    }
}
