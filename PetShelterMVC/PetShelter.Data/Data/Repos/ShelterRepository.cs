using System;

[AutoBind]
public class ShelterRepository : BaseRepository<Shelter, ShelterDto>, IShelterRepository
{
	public ShelterRepository(ShelterhelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
