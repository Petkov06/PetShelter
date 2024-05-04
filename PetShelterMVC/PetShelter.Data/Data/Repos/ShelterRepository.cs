using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;


[AutoBind]
public class ShelterRepository : BaseRepository<Shelter, ShelterDto>, IShelterRepository
{
	public ShelterRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
