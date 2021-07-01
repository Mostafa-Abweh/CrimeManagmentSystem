using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
  public  interface IAcussedService
    {
        Acussed Create(Acussed acussed);
        Acussed Update(Acussed acussed);
        List<Acussed> GetAll();
        Acussed GetById(int id);
        bool Delete(int id);
        List<Acussed> Search(AcussedDTO acussedDTO);
    }
}
