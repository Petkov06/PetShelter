using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{ 
    public interface IPetRepository : IBaseRepository<PetDto>
    {
        public Task GivePetAsync(int? userId, int? shelterId, PetDto pet);
        public Task AdoptPetAsync(int userId, int petId);

        public Task<IEnumerable<PetDto>> GetAllActiveAsync();
    }
}
