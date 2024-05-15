using System;
using System.Threading.Tasks;
using AutoMapper;
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
    public async Task GivePetAsync(int userId, PetDto pet)
    {
         
    }
    public async Task AdoptPetAsync(int userId, int petId)
    {

    }
}

