using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Services.ViewModels;
using PetShelter.Shared.Dtos;

namespace PetShelterMVC
{
    public class AutoMapperConfiguration:Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Breed, BreedDto>().ReverseMap();
            CreateMap<BreedDto, BreedEditVM>().ReverseMap();
        }
    }
}
