﻿using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Services.Contracts
{
    public interface IPetVaccinesService : IBaseCrudService<PetVaccineDto, IPetVaccineRepository>

    {
        public Task VaccinatePetAsync(int petId, int vaccineId);
        public Task<IEnumerable<PetVaccineDto>> GetAllAsync();
    }
}
