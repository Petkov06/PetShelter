using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelterMVC.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{


    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class LocationController : BaseCrudController<LocationDto, ILocationRepository, ILocationsService, LocationEditVM, LocationDetailsVM>
    {
        public LocationController(ILocationsService service, IMapper mapper) : base(service, mapper)
        {

        }

       
    }
}

