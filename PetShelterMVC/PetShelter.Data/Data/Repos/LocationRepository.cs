using System;


[AutoBind]
public class LocationRepository : BaseRepository<Location, LocationDto>, ILocationRepository
{
	public LocationRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

