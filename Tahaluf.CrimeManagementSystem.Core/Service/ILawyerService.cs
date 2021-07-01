using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface ILawyerService
    {
        Lawyer Create(Lawyer lawyer);
        List<Lawyer> GetAll();
        Lawyer Update(Lawyer lawyer);
        bool Delete(int id);
        Lawyer GetById(int id);
    }
}
