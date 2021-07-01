using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
   public interface ICrimeService
    {
        Crime Create(Crime crime);
        Crime Update(Crime crime);
        List<Crime> GetAll();
        Crime GetById(int id);
        bool Delete(int id);
        List<Crime> Search(CrimeDTO crimeDTO);
    }
}
