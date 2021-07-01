using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
    public interface IWitnessRepository
    {
        int Create(Witness witness);
        List<Witness> GetAll();
        int Update(Witness witness);
        bool Delete(int id);
        Witness GetById(int id);
    }
}
