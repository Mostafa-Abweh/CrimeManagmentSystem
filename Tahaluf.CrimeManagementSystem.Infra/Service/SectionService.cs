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
   public class SectionService: ISectionService
    {

        private readonly ISectionRepository _sectionRepository;
        public SectionService(ISectionRepository _sectionRepository)
        {
            this._sectionRepository = _sectionRepository;
        }

        public Task<List<Section>> GetAll()
        {
            return _sectionRepository.GetAll();
        }
        public Section Update(Section section)
        {
            _sectionRepository.Update(section);
            return section;
        }
        public Section Create(Section section)
        {
            _sectionRepository.Create(section);
            return section;
        }
        public bool Delete(int id)
        {
            return _sectionRepository.Delete(id);
        }
        public Task<List<Section>> GetById(int id)
        {
            return _sectionRepository.GetById(id);
        }
        public Task<List<Section>> Search(SectionDTO sectionDTO)
        {
            return _sectionRepository.Search(sectionDTO);
        }
    }
}
