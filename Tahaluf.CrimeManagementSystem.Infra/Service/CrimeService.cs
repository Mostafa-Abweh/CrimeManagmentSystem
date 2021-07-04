using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
   public class CrimeService: ICrimeService
    {
        private readonly ICrimeRepository _crimeRepository;
        public CrimeService(ICrimeRepository _crimeRepository)
        {
            this._crimeRepository = _crimeRepository;
        }

        public Task<List<Crime>> GetAll()
        {
            return _crimeRepository.GetAll();
        }
        public Crime Update(Crime crime)
        {
            _crimeRepository.Update(crime);
            return crime;
        }
        public Crime Create(Crime crime)
        {
            _crimeRepository.Create(crime);
            return crime;
        }
        public bool Delete(int id)
        {
            return _crimeRepository.Delete(id);
        }
        public Task<List<Crime>> GetById(int id)
        {
            return _crimeRepository.GetById(id);
        }
        public Task<List<Crime>> Search(CrimeDTO crimeDTO)
        {
            return _crimeRepository.Search(crimeDTO);
        }
    }
}
