using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;




[AutoBind]
public class PetRepository : BaseRepository<Pet, PetDto>, IPetRepository
{
	public PetRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

