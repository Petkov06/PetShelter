using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;


[AutoBind]
public class BreedRepository : BaseRepository<Breed,BreedDto>,IBreedRepository
{
	public BreedRepository(PetShelterDbContext context, IMapper mapper):base(context, mapper)
	{
	}
}
