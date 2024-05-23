﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelterMVC.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter.Services;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class PetController : BaseCrudController<PetDto, IPetRepository, IPetsService, PetEditVM, PetDetailsVM>
    {
        public IPetTypeService _petTypeService { get; set; }
        public IBreedsService _breedsService { get; set; }
        public IPetVaccinesService _petVaccineService { get; set; }
        public IPetsService _petsService { get; set; }
        public PetController(IPetsService service, IMapper mapper, IPetTypeService _petTypeService, IBreedsService _breedsService, IPetVaccinesService _petVaccineService, IPetsService _petsService) : base(service, mapper)
        {

            this._petTypeService = _petTypeService;
            this._breedsService = _breedsService;
            this._petVaccineService = _petVaccineService;
        }



        public override async Task<PetEditVM> PrePopulateVMAsync()
        {
            var editVM = new PetEditVM
            {
                PetTypeList = (await _petTypeService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString())),
                BreedList = (await _breedsService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()))
            };
            return editVM;
        }

        public async Task VaccinatePetAsync(PetVaccineEditVM editVM)
        {
            await _petVaccineService.VaccinatePetAsync(editVM.PetId, editVM.VaccineId);
        }

        public async Task GivePetAsync(PetEditVM editVM)
        {
            await _petsService.GivePetAsync(editVM.GiverId,editVM.ShelterId,_mapper.Map<PetDto>(editVM));
        }

    }
}
