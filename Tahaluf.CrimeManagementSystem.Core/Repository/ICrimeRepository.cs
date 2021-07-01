using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface ICrimeRepository
    {
        int Create(Crime crime);
        int Update(Crime crime);
        bool Delete(int id);
        List<Crime> GetAll();
        Crime GetById(int id);

        List<Crime> Search(CrimeDTO crimeDTO);
    }
}
