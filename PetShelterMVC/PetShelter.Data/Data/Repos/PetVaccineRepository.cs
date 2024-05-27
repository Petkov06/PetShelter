using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PetShelter.Data;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;



[AutoBind]
public class PetVaccineRepository : BaseRepository<PetVaccine, PetVaccineDto>, IPetVaccineRepository
{
    public PetVaccineRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
    {

    }
    public async Task VaccinatePetAsync(int petId, int vaccineId)
    {
        var petVaccine = new PetVaccineDto(petId, vaccineId);
        await SaveAsync(petVaccine);
    }
}
