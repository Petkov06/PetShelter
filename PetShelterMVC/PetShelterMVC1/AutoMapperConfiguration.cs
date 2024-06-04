using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelterMVC.ViewModels;

namespace PetShelterMVC
{
    public class AutoMapperConfiguration:Profile
    {

        public AutoMapperConfiguration()
        {
            CreateMap<Breed, BreedDto>().ReverseMap();
            CreateMap<BreedDto, BreedEditVM>().ReverseMap();
            CreateMap<BreedDto, BreedDetailsVM>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<LocationDto, LocationEditVM>().ReverseMap();
            CreateMap<LocationDto, LocationDetailsVM>().ReverseMap();
            CreateMap<Pet, PetDto>().ReverseMap();
            CreateMap<PetDto, PetEditVM>().ReverseMap();
            CreateMap<PetDto, PetDetailsVM>().ReverseMap();
            CreateMap<PetType, PetTypeDto>().ReverseMap();
            CreateMap<PetTypeDto, PetTypeEditVM>().ReverseMap();
            CreateMap<PetTypeDto, PetTypeDetailsVM>().ReverseMap();
            CreateMap<PetVaccine, PetVaccineDto>().ReverseMap();
            CreateMap<PetVaccineDto, PetVaccineDetailsVM>().ReverseMap();
            CreateMap<PetVaccineEditVM, PetVaccineDto>();
            CreateMap<PetVaccineDto, PetVaccineEditVM>();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<RoleDto, RoleEditVM>().ReverseMap();
            CreateMap<RoleDto, RoleDetailsVM>().ReverseMap();
            CreateMap<Shelter, ShelterDto>().ReverseMap();
            CreateMap<ShelterDto, ShelterEditVM>().ReverseMap();
            CreateMap<ShelterDto, ShelterDetailsVM>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserDto, UserEditVM>().ReverseMap();
            CreateMap<UserDto, UserDetailsVM>().ReverseMap();
            CreateMap<Vaccine, VaccineDto>().ReverseMap();
            CreateMap<VaccineDto, VaccineEditVM>().ReverseMap();
            CreateMap<VaccineDto, VaccineDetailsVM>().ReverseMap();
            CreateMap<ChangePasswordDto, ChangePasswordVM>().ReverseMap();
            CreateMap<LoginDto, LoginVm>().ReverseMap();
            CreateMap<RegisterVM, UserDto>();

        }
    }
}
