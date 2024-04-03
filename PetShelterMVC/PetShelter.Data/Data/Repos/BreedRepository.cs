using System;

[AutoBind]
public class BreedRepository : BaseRepository<Breed,BreedDto>,IBreedRepository
{
	public BreedRepository(PetShelterDbContext context, IMapper mapper):base(context, mapper)
	{
	}
}
