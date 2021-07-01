using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
   public class JudgeService: IJudgeService
    {
        private readonly IJudgeRepository _judgeRepository;
        public JudgeService(IJudgeRepository _judgeRepository)
        {
            this._judgeRepository = _judgeRepository;
        }

        public List<Judge> GetAll()
        {
            return _judgeRepository.GetAll();
        }
        public Judge Update(Judge judge)
        {
            _judgeRepository.Update(judge);
            return judge;
        }
        public Judge Create(Judge judge)
        {
            _judgeRepository.Create(judge);
            return judge;
        }
        public bool Delete(int id)
        {
            return _judgeRepository.Delete(id);
        }
        public Judge GetById(int id)
        {
            return _judgeRepository.GetById(id);
        }
        public List<Judge> Search(JudgeDTO judgeDTO)
        {
            return _judgeRepository.Search(judgeDTO);
        }
    }
}
