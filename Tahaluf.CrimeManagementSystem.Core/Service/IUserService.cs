using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IUserService
    {
        User Create(User user);
        Task<List<User>> GetAll();
        User Update(User user);
        bool Delete(int id);
        Task<List<User>> GetById(int id);
    }
}
