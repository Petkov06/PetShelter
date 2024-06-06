using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;




[AutoBind]
public class PetRepository : BaseRepository<Pet, PetDto>, IPetRepository

{
    public PetRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
    {

    }
    public async Task GivePetAsync(int? userId, int? shelterId, PetDto pet)
    {

        pet.UserId = userId;
        pet.ShelterId = shelterId;
        await SaveAsync(pet);
    }
    public async Task AdoptPetAsync(int userId, int petId)
    {
        var pet = await GetByIdAsync(petId);
        pet.AdopterId = userId;
        pet.IsAdopted = true;
        await SaveAsync(pet);

    }

    public async Task<IEnumerable<PetDto>> GetAllActiveAsync()
    {
        return MapToEnumerableOfModel(await _dbSet.Where(l => l.ShelterId == null).ToListAsync());
    }
}

