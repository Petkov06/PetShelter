﻿using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IPetVaccineRepository : IBaseRepository<PetVaccineDto>
    {
        public Task VaccinatePetAsync(int petId, int vaccineId);
        public Task<IEnumerable<PetVaccineDto>> GetAllAsync();
    }
}
