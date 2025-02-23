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
using System.Security.Claims;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.AspNetCore.Mvc;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class PetController : BaseCrudController<PetDto, IPetRepository, IPetsService, PetEditVM, PetDetailsVM>
    {
        public IPetTypeService _petTypeService { get; set; }
        public IBreedsService _breedsService { get; set; }
        public IVaccinesService _vaccineService { get; set; }
        public IUsersService _usersService { get; set; }

        public IPetVaccinesService _petVaccinesService { get; set; }
        public PetController(IPetsService service, IMapper mapper, IPetTypeService _petTypeService, IBreedsService _breedsService, IVaccinesService _vaccineService, IUsersService _usersService, IPetVaccinesService _petVaccinesService) : base(service, mapper)
        {

            this._petTypeService = _petTypeService;
            this._breedsService = _breedsService;
            this._vaccineService = _vaccineService;
            this._usersService = _usersService;
            this._petVaccinesService = _petVaccinesService;
        }



        protected override async Task<PetEditVM> PrePopulateVMAsync(PetEditVM editVM)
        {

            editVM.PetTypeList = (await _petTypeService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            editVM.BreedList = (await _breedsService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            editVM.UserList = (await _usersService.GetAllAsync()).Select(x => new SelectListItem($"{x.FirstName} {x.LastName}", x.Id.ToString()));


            return editVM;
        }
       
           
        protected async Task<AdoptPetEditVM> PrePopulateVMAsync(AdoptPetEditVM editVM)
        {

            editVM.PetList = (await _service.GetAllActiveAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));

            return editVM;
        }
        [HttpGet]
        public async Task<IActionResult> GivePetAsync()
        {

            var editVM = await PrePopulateVMAsync(new PetEditVM());
            return View(editVM);
        }
        [HttpPost]
        public async Task<IActionResult> GivePetAsync(PetEditVM editVM)
        {
            var errors = await Validate(editVM);
            if (errors != null)
            {
                return View(editVM);
            }
            var model = _mapper.Map<PetDto>(editVM);
            await this._service.SaveAsync(model);
            return await List();
        }
        [HttpGet]
        public async Task<IActionResult> AdoptPetAsync()
        {
            var editVM = await PrePopulateVMAsync(new AdoptPetEditVM());
            return View(editVM);
        }
        [HttpPost]
        public async Task<IActionResult> AdoptPetAsync(AdoptPetEditVM editVM)
        {
            string loggedUsername = User.FindFirst(ClaimTypes.Name)?.Value;
            var user = await this._usersService.GetByUsernameAsync(loggedUsername);
            await this._service.AdoptPetAsync(user.Id, editVM.PetId);
            return await List();
        }


        protected async Task<PetVaccineEditVM> PrePopulateVMAsync(PetVaccineEditVM editVM)
        {
            editVM.PetList = (await _service.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            editVM.VaccineList = (await _vaccineService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));

            return editVM;
        }
        [HttpGet]
        public async Task<IActionResult> VaccinatePetAsync()
        {
            var editVM = await PrePopulateVMAsync(new PetVaccineEditVM());
            return View(editVM);
        }
        [HttpPost]
        public async Task<IActionResult> VaccinatePetAsync(PetVaccineEditVM editVM)
        {
            string loggedUsername = User.FindFirst(ClaimTypes.Name)?.Value;
            var user = await this._usersService.GetByUsernameAsync(loggedUsername);
            await this._petVaccinesService.VaccinatePetAsync( editVM.PetId, editVM.VaccineId);
            return await List();
        }

        
    }
}
