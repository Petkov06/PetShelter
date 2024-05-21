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
    public class PetsVaccineService : BaseCrudService<PetVaccineDto, IPetVaccineRepository>, IPetVaccinesService
    {
        public PetsVaccineService(IPetVaccineRepository repository) : base(repository)
        {

        }
        public async Task VaccinatePetAsync(int petId, int vaccineId)
        {
            await _repository.VaccinatePetAsync(petId, vaccineId);
        }
    }

}
