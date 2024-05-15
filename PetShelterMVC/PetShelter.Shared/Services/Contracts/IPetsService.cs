﻿using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Services.Contracts
{
    public interface IPetsService : IBaseCrudService<PetDto, IPetRepository>
    {
        public Task GivePetAsync(int userId, PetDto pet);
        public Task AdoptPetAsync(int userId, int petId);
    }
}
