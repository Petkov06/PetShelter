using System;


[AutoBind]
public class PetRepository : BaseRepository<Pet, PetDto>, IPetRepository
{
	public PetRepository(PethelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

