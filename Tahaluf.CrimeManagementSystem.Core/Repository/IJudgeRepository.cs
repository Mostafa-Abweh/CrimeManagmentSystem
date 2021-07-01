using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;

namespace Tahaluf.CrimeManagementSystem.Core.Repository
{
   public interface IJudgeRepository
    {
        int Create(Judge judge);
        int Update(Judge judge);
        bool Delete(int id);
        List<Judge> GetAll();
        Judge GetById(int id);

        List<Judge> Search(JudgeDTO judgeDTO);
    }
}
