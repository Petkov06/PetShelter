using System;

[AutoBind]
public class PetVaccineRepository : BaseRepository<PetVaccine, PetVaccineDto>, IPetVaccineRepository
{
	public PetVaccineRepository(PetVaccineShelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
