using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Services.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class PetTypeController : BaseCrudController<PetTypeDto, IPetTypeRepository, IPetTypeService, PetTypeEditVM, PetTypeDetailsVM>
    {
        public PetTypeController(IPetTypeService service, IMapper mapper) : base(service, mapper)
        {

        }


    }
}
