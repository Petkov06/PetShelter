using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;


[AutoBind]
public class BreedsRepository : BaseRepository<Breed, BreedDto>, IBreedRepository
{
	public BreedsRepository(PetShelterDbContext context, IMapper mapper):base(context, mapper)
	{
	}
}
