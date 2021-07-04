using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class LawyerService : ILawyerService
    {
        private readonly ILawyerRepository LawyerRepository;
        public LawyerService(ILawyerRepository _lawyerRepository)
        {
            this.LawyerRepository = _lawyerRepository;
        }

        public Task<List<Lawyer>> GetAll()
        {
            return LawyerRepository.GetAll();
        }
        public Lawyer Update(Lawyer lawyer)
        {
            LawyerRepository.Update(lawyer);
            return lawyer;
        }
        public Lawyer Create(Lawyer lawyer)
        {
            LawyerRepository.Create(lawyer);
            return lawyer;
        }
        public bool Delete(int id)
        {
            return LawyerRepository.Delete(id);
        }
        public Task<List<Lawyer>> GetById(int id)
        {
            return LawyerRepository.GetById(id);
        }
    }
}
