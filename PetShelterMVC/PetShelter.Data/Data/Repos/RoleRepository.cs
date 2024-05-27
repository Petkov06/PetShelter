using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Attributes;
using System.Threading.Tasks;
using PetShelter.Data;
using Microsoft.EntityFrameworkCore;


[AutoBind]
public class RoleRepository : BaseRepository<Role, RoleDto>, IRoleRepository
{
	public RoleRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
    public async Task<RoleDto> GetByNameIfExistsAsync(string name)
	{
		return MapToModel(await _dbSet.FirstOrDefaultAsync(r => r.Name == name));
    }
}
