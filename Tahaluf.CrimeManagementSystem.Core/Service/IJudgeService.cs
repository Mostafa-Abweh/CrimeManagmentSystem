using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Service
{
   public interface IJudgeService
    {
        Judge Create(Judge judge);
        Judge Update(Judge judge);
        Task<List<Judge>> GetAll();
        Task<List<Judge>> GetById(int id);
        bool Delete(int id);
        Task<List<Judge>> Search(JudgeDTO judgeDTO);
    }
}
