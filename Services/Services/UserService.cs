using Domain.Entities.User;
using Domain.Entities.User.Dto;
using Repository.Repository.User;
using Services.IService.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository; 
        public UserService(UserRepository user)
        {
            _userRepository = user;
        }

        public async Task<int> CreateUser(UserDto users)
        {

            return 1;
        }
 
  


    }
}
