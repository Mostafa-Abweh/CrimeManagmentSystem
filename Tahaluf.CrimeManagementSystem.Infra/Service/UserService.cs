using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;
using Tahaluf.CrimeManagementSystem.Core.Service;

namespace Tahaluf.CrimeManagementSystem.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;
        public UserService(IUserRepository _userRepository)
        {
            this.UserRepository = _userRepository;
        }

        public List<User> GetAll()
        {
            return UserRepository.GetAll();
        }
        public User Update(User user)
        {
            UserRepository.Update(user);
            return user;
        }
        public User Create(User user)
        {
            UserRepository.Create(user);
            return user;
        }
        public bool Delete(int id)
        {
            return UserRepository.Delete(id);
        }
        public User GetById(int id)
        {
            return UserRepository.GetById(id);
        }
    }
}
