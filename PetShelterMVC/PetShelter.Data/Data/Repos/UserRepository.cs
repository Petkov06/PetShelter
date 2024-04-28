using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;


[AutoBind]
public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
{
	public UserRepository(UserhelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
