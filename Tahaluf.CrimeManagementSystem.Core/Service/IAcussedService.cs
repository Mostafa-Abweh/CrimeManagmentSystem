using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
  public  interface IAcussedService
    {
        Acussed Create(Acussed acussed);
        Acussed Update(Acussed acussed);
        Task<List<Acussed>> GetAll();
        Task<List<Acussed>> GetById(int id);
        bool Delete(int id);
        Task<List<Acussed>> Search(AcussedDTO acussedDTO);
    }
}
