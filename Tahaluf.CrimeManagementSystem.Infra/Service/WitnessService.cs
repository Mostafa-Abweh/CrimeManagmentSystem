using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class WitnessService : IWitnessService
    {
        private readonly IWitnessRepository WitnessRepository;
        public WitnessService(IWitnessRepository _witnessRepository)
        {
            this.WitnessRepository = _witnessRepository;
        }

        public Task<List<Witness>> GetAll()
        {
            return WitnessRepository.GetAll();
        }
        public Witness Update(Witness witness)
        {
            WitnessRepository.Update(witness);
            return witness;
        }
        public Witness Create(Witness witness)
        {
            WitnessRepository.Create(witness);
            return witness;
        }
        public bool Delete(int id)
        {
            return WitnessRepository.Delete(id);
        }
        public Task<List<Witness>> GetById(int id)
        {
            return WitnessRepository.GetById(id);
        }
    }
}
