using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Attributes;



[AutoBind]
public class PetTypeRepository : BaseRepository<PetType, PetTypeDto>, IPetTypeRepository
{
	public PetTypeRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

