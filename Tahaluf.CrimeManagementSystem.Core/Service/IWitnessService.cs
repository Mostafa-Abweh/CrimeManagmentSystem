using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
    public interface IWitnessService
    {
        Witness Create(Witness witness);
        List<Witness> GetAll();
        Witness Update(Witness witness);
        bool Delete(int id);
        Witness GetById(int id);
    }
}
