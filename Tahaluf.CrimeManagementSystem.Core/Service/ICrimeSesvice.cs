using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
   public interface ICrimeService
    {
        Crime Create(Crime crime);
        Crime Update(Crime crime);
        Task<List<Crime>> GetAll();
        Task<List<Crime>> GetById(int id);
        bool Delete(int id);
        Task<List<Crime>> Search(CrimeDTO crimeDTO);
    }
}
