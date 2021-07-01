using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
   public class AcussedService:IAcussedService
    {

        private readonly IAcussedRepository _acussedRepository;
        public AcussedService(IAcussedRepository _acussedRepository)
        {
            this._acussedRepository = _acussedRepository;
        }

        public List<Acussed> GetAll()
        {
            return _acussedRepository.GetAll();
        }
        public Acussed Update(Acussed acussed)
        {
            _acussedRepository.Update(acussed);
            return acussed;
        }
        public Acussed Create(Acussed acussed)
        {
            _acussedRepository.Create(acussed);
            return acussed;
        }
        public bool Delete(int id)
        {
            return _acussedRepository.Delete(id);
        }
        public Acussed GetById(int id)
        {
            return _acussedRepository.GetById(id);
        }
        public List<Acussed> Search(AcussedDTO acussedDTO)
        {
            return _acussedRepository.Search(acussedDTO);
        }
    }
}
