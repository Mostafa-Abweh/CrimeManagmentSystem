using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IUserService
    {
        User Create(User user);
        List<User> GetAll();
        User Update(User user);
        bool Delete(int id);
        User GetById(int id);
    }
}
