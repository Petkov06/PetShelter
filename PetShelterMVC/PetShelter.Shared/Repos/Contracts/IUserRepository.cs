﻿using Microsoft.EntityFrameworkCore;
using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IUserRepository : IBaseRepository<UserDto>
    {
        public Task<UserDto> GetByUsernameAsync(string username);
        public  Task<bool> CanUserLoginAsync(string username, string password);
    }
}
