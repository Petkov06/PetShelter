﻿using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{

    [AutoBind]
    public class PetsService : BaseCrudService<PetDto, IPetRepository>, IPetsService
    {
        public PetsService(IPetRepository repository) : base(repository)
        {

        }

        public async Task GivePetAsync(int userId, int shelterId, PetDto pet)
        {
            await _repository.GivePetAsync(userId, shelterId, pet);
        }
        public async Task AdoptPetAsync(int userId, int petId)
        {
            await _repository.AdoptPetAsync(userId, petId);
        }
    }

}
