using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface ILawyerRepository
    {
        int Create(Lawyer lawyer);
        List<Lawyer> GetAll();
        int Update(Lawyer lawyer);
        bool Delete(int id);
        Lawyer GetById(int id);
    }
}
