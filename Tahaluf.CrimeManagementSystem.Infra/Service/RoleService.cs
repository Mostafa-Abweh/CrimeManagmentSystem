using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository RoleRepository;
        public RoleService(IRoleRepository _roleRepository)
        {
            this.RoleRepository = _roleRepository;
        }

        public List<Role> GetAll()
        {
            return RoleRepository.GetAll();
        }
        public Role Update(Role role)
        {
            RoleRepository.Update(role);
            return role;
        }
        public Role Create(Role role)
        {
            RoleRepository.Create(role);
            return role;
        }
        public bool Delete(int id)
        {
            return RoleRepository.Delete(id);
        }
        public Role GetById(int id)
        {
            return RoleRepository.GetById(id);
        }
    }
}
