using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelterMVC.ViewModels;
using System.Threading.Tasks;
using System;
using PetShelter.Data.Entities;
using System.Linq;
using PetShelter.Shared.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User ")]
    public class BreedController : BaseCrudController<BreedDto, IBreedRepository, IBreedsService, BreedEditVM, BreedDetailsVM>
    {
        public BreedController(IBreedsService service, IMapper mapper) : base(service, mapper)
        {

        }
        protected override async Task<BreedEditVM> PrePopulateVMAsync(BreedEditVM editVM)
        {
            editVM.BreedList = Enum.GetValues(typeof(BreedSize)).Cast<BreedSize>().Select(s => new SelectListItem(s.ToString(), ((int)s).ToString()));
            return editVM;

        }
    }
}
