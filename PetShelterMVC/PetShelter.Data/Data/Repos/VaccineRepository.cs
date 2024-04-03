using System;

[AutoBind]
public class VaccineRepository : BaseRepository<Vaccine, VaccineDto>, IVaccineRepository
{
	public VaccineRepository(VaccinehelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
