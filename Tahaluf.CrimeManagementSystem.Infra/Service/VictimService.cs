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
    public class VictimService :IVictimService
    {
        private readonly IVictimRepository _victimRepository;
        public VictimService(IVictimRepository _victimRepository)
        {
            this._victimRepository = _victimRepository;
        }

        public Task<List<Victim>> GetAll()
        {
            return _victimRepository.GetAll();
        }
        public Victim Update(Victim victim)
        {
            _victimRepository.Update(victim);
            return victim;
        }
        public Victim Create(Victim victim)
        {
            _victimRepository.Create(victim);
            return victim;
        }
        public bool Delete(int id)
        {
            return _victimRepository.Delete(id);
        }
        public Task<List<Victim>> GetById(int id)
        {
            return _victimRepository.GetById(id);
        }
        public Task<List<Victim>> Search(VictimDTO victimDTO)
        {
            return _victimRepository.Search(victimDTO);
        }
    }
}
