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
    public class PetsService : BaseCrudService<PetDto, IPetRepository>, IPetsService
    {
        public UserService _userService { get; set; }
        public ShelterService _shelterService { get; set; }
        public PetsService _petsService {  get; set; }

        public PetsService(IPetRepository repository, UserService userService, ShelterService shelterService, PetsService petsService) : base(repository)
        {
            _userService = userService;
            _shelterService = shelterService;
            _petsService = petsService;
        }

        public async Task GivePetAsync(int userId, int shelterId, PetDto pet)
        {

            if (!await _userService.ExistsByIdAsync(userId))
            {
                throw new ArgumentException($"User with ID {userId} does not exist.");
            }
            if (!await _shelterService.ExistsByIdAsync(shelterId))
            {
                throw new ArgumentException($"Shelter with ID {shelterId} does not exist.");
            }
            await _repository.GivePetAsync(userId, shelterId, pet);
        }
        public async Task AdoptPetAsync(int userId, int petId)
        {
            if (!await _userService.ExistsByIdAsync(userId))
            {
                throw new ArgumentException($"User with ID {userId} does not exist.");
            }
            if (!await _petsService.ExistsByIdAsync(petId))
            {
                throw new ArgumentException($"Pet with ID {petId} does not exist.");
            }
            await _repository.AdoptPetAsync(userId, petId);
        }
    }

}
