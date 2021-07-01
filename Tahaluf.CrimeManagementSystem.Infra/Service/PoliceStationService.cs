using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class PoliceStationService : IPoliceStationService
    {
        private readonly IPoliceStationRepository PSRepository;
        public PoliceStationService(IPoliceStationRepository _pSRepository)
        {
            this.PSRepository = _pSRepository;
        }

        public List<PoliceStation> GetAll()
        {
            return PSRepository.GetAll();
        }
        public PoliceStation Update(PoliceStation PS)
        {
            PSRepository.Update(PS);
            return PS;
        }
        public PoliceStation Create(PoliceStation PS)
        {
            PSRepository.Create(PS);
            return PS;
        }
        public bool Delete(int id)
        {
            return PSRepository.Delete(id);
        }
        public PoliceStation GetById(int id)
        {
            return PSRepository.GetById(id);
        }
    }
}
