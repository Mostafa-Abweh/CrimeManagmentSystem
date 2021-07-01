using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IUserRepository
    {
        int Create(User user);
        List<User> GetAll();
        int Update(User user);
        bool Delete(int id);
        User GetById(int id);
    }
}
