using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IOfficerService
    {
        Officer Create(Officer officer);
        Task<List<Officer>> GetAll();
        Officer Update(Officer officer);
        bool Delete(int id);
        Task<List<Officer>> GetById(int id);
    }
}
