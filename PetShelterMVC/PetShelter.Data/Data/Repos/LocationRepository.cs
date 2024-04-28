using System;
using AutoMapper;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;



[AutoBind]
public class LocationRepository : BaseRepository<Location, LocationDto>, ILocationRepository
{
	public LocationRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

