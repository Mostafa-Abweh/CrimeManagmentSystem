using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface ICrimeRepository
    {
        int Create(Crime crime);
        int Update(Crime crime);
        bool Delete(int id);
        Task<List<Crime>> GetAll();
        Task<List<Crime>> GetById(int id);

        Task<List<Crime>> Search(CrimeDTO crimeDTO);
    }
}
