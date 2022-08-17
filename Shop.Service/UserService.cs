using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;
using Shop.Repository.Shop_Repository;

namespace Shop.Service
{
    public class UserService : IUserService
    {
        private IUserRepository<User> userRepository;

        public UserService(IUserRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(long id)
        {
            User user = userRepository.Get(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }
}
