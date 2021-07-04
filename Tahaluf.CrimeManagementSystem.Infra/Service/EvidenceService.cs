using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class EvidenceService:IEvidenceService
    {
        private readonly IEvidenceRepository _evidenceRepository;
        public EvidenceService(IEvidenceRepository _evidenceRepository)
        {
            this._evidenceRepository = _evidenceRepository;
        }

        public Task<List<Evidence>> GetAll()
        {
            return _evidenceRepository.GetAll();
        }
        public Evidence Update(Evidence evidence)
        {
            _evidenceRepository.Update(evidence);
            return evidence;
        }
        public Evidence Create(Evidence evidence)
        {
            _evidenceRepository.Create(evidence);
            return evidence;
        }
        public bool Delete(int id)
        {
            return _evidenceRepository.Delete(id);
        }
        public Task<List<Evidence>> GetById(int id)
        {
            return _evidenceRepository.GetById(id);
        }
    }
}
