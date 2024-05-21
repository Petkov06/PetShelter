using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{

    [AutoBind]
    public class UserService : BaseCrudService<UserDto, IUserRepository>, IUsersService
    {
        public UserService(IUserRepository repository) : base(repository)
        {

        }

        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            return await _repository.GetByUsernameAsync(username);
        }
        public async Task<bool> CanUserLoginAsync(string username, string password)
        {
            return await _repository.CanUserLoginAsync(username, password);
        }
         
    
    }
}

