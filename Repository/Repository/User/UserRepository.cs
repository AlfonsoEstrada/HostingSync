﻿using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.User
{
    public class UserRepository
    {

        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> CreateUser(Users model)
        {
            await _context.Users.AddAsync(model);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _context.Users.Where(x => x.IsDeleted == false).ToListAsync();
        }


    }
}
