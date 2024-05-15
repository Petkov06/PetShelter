using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Services.Contracts
{
    
    public interface IUsersService : IBaseCrudService<UserDto, IUserRepository>

    {
        public Task<UserDto> GetByUsernameAsync(string username);
        public Task<bool> CanUserLoginAsync(string username, string password);
    }
}
