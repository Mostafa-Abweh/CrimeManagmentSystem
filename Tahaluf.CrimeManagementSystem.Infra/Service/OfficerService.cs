using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class OfficerService : IOfficerService
    {
        private readonly IOfficerRepository OfficerRepository;
        public OfficerService(IOfficerRepository _officerRepository)
        {
            this.OfficerRepository = _officerRepository;
        }

        public Task<List<Officer>> GetAll()
        {
            return OfficerRepository.GetAll();
        }
        public Officer Update(Officer officer)
        {
            OfficerRepository.Update(officer);
            return officer;
        }
        public Officer Create(Officer officer)
        {
            OfficerRepository.Create(officer);
            return officer;
        }
        public bool Delete(int id)
        {
            return OfficerRepository.Delete(id);
        }
        public Task<List<Officer>> GetById(int id)
        {
            return OfficerRepository.GetById(id);
        }
    }
}
