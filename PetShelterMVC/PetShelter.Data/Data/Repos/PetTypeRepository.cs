using System;


[AutoBind]
public class PetTypeRepository : BaseRepository<PetType, PetTypeDto>, IPetTypeRepository
{
	public PetTypeRepository(PetTypeShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}

