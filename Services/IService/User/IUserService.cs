using Domain.Entities.User;
using Domain.Entities.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService.User
{
    public interface IUserService
    {
        Task<int> CreateUser(UserDto user);
    }
}
