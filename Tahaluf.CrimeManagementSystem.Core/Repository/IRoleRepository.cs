using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IRoleRepository
    {
        int Create(Role role);
        List<Role> GetAll();
        int Update(Role role);
        bool Delete(int id);
        Role GetById(int id);
    }
}
