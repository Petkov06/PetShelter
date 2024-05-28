using AutoMapper;
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
            CreateMap<BreedDto,BreedDetailsVM>().ReverseMap();
            CreateMap<ChangePasswordDto, ChangePasswordVM>().ReverseMap();
            CreateMap<LocationDto, LocationDetailsVM>().ReverseMap();
            CreateMap<LocationDto,LocationEditVM>().ReverseMap();
            CreateMap<LoginDto,LoginVm>().ReverseMap();
            CreateMap<PetDto, PetEditVM>().ReverseMap();
            CreateMap<PetDto,PetDetailsVM>().ReverseMap();
            CreateMap<PetTypeDto, PetTypeEditVM>().ReverseMap();
            CreateMap<PetTypeDto,PetTypeDetailsVM>().ReverseMap();
            CreateMap<PetVaccineDto,PetVaccineDetailsVM>().ReverseMap();
            CreateMap<ShelterDto, ShelterEditVM>().ReverseMap();
            CreateMap<ShelterDto,ShelterDetailsVM>().ReverseMap();
            CreateMap<RoleDto, RoleEditVM>().ReverseMap();
            CreateMap<RoleDto,RoleDetailsVM>().ReverseMap();
            CreateMap<UserDto,RegisterVM>().ReverseMap();
            CreateMap<UserDto,UserEditVM>().ReverseMap();
            CreateMap<UserDto,UserDetailsVM>().ReverseMap();
            CreateMap<VaccineDto,VaccineDetailsVM>().ReverseMap();
            CreateMap<VaccineDto,VaccineEditVM>().ReverseMap();

        }
    }
}
