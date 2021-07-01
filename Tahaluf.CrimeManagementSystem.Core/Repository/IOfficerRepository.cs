using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IOfficerRepository
    {
        int Create(Officer officer);
        List<Officer> GetAll();
        int Update(Officer officer);
        bool Delete(int id);
        Officer GetById(int id);
    }
}
