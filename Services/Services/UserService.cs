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
            Users user = new()
            {
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                GroupId = users.GroupId,
                HotelId = users.HotelId,
                CreatedBy = users.CreatedBy,
                CreatedDate = users.CreatedDate,
                ModifiedBy= users.ModifiedBy,
                ModifiedDate = users.ModifiedDate,
                IsDeleted = users.IsDeleted,
                

            };

            return await _userRepository.CreateUser(user);
        }

        public async Task<List<UserDto>> GetUsers()
        {
            List<Users> users = await _userRepository.GetUsers();
            List<UserDto> userDtos = new();
            
            foreach(var user in users)
            {
                UserDto dto = new UserDto()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Password = user.Password,
                    GroupId = user.GroupId,
                    HotelId= user.HotelId,
                    CreatedBy = user.CreatedBy,
                    CreatedDate = user.CreatedDate,
                    ModifiedBy= user.ModifiedBy,
                    ModifiedDate = user.ModifiedDate,
                    IsDeleted = user.IsDeleted
                };
                
                userDtos.Add(dto);

            }
            
            return userDtos;
                
        }
 
  


    }
}
