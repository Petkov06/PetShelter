using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelterMVC.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class VaccineController : BaseCrudController<VaccineDto, IVaccineRepository, IVaccinesService, VaccineEditVM, VaccineDetailsVM>
    {
        public VaccineController(IVaccinesService service, IMapper mapper) : base(service, mapper)
        {

        }


    }
}
