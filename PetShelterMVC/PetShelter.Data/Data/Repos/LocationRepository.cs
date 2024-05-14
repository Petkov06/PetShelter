using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;




[AutoBind]
public class LocationRepository : BaseRepository<Location, LocationDto>, ILocationRepository
{
	public LocationRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}

    public async Task<IEnumerable<LocationDto>> GetAllActiveAsync()
    {
        return MapToEnumerableOfModel(await _dbSet.Where(l => l.ShelterId == null).ToListAsync());
    }
}

