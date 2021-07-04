using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IRoleRepository
    {
        int Create(Role role);
        Task<List<Role>> GetAll();
        int Update(Role role);
        bool Delete(int id);
        Task<List<Role>> GetById(int id);
    }
}
