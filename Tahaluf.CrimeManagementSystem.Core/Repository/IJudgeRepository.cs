using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IJudgeRepository
    {
        int Create(Judge judge);
        int Update(Judge judge);
        bool Delete(int id);
        Task<List<Judge>> GetAll();
        Task<List<Judge>> GetById(int id);

        Task<List<Judge>> Search(JudgeDTO judgeDTO);
    }
}
