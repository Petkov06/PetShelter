using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Attributes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


[AutoBind]
public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
{
    public UserRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
    {

    }
    public async Task<UserDto> GetByUsernameAsync(string username)
    {
        return MapToModel(await _dbSet.FirstOrDefaultAsync(u => u.Username == username));

    }
    public async Task<bool> CanUserLoginAsync(string username, string password)
    {
        return await _dbSet.AnyAsync(ul => ul.Username == username && ul.Password == password);
    }
}
