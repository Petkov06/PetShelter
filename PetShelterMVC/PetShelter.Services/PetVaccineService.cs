using PetShelter.Shared.Attributes;
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
        public PetsService _petsService { get; set; }
        public VaccineService _vaccineService { get; set; }

        public PetsVaccineService(IPetVaccineRepository repository, PetsService petsService, VaccineService vaccineService) : base(repository)
        {
            _petsService = petsService;
            _vaccineService = vaccineService;
        }

        public async Task VaccinatePetAsync(int petId, int vaccineId)
        {
            if (!await _petsService.ExistsByIdAsync(petId))
            {
                throw new ArgumentException($"Pet with ID {petId} does not exist.");
            }
            if (!await _vaccineService.ExistsByIdAsync(vaccineId))
            {
                throw new ArgumentException($"Vaccine with ID {vaccineId} does not exist.");
            }
           
            await _repository.VaccinatePetAsync(petId, vaccineId);
        }
    }

}
