using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IOfficerService
    {
        Officer Create(Officer officer);
        List<Officer> GetAll();
        Officer Update(Officer officer);
        bool Delete(int id);
        Officer GetById(int id);
    }
}
