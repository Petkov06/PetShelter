using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Services.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, IShelterRepository, ISheltersService, ShelterEditVM, ShelterDetailsVM>
    {
        public ILocationsService _locationsService { get; set; }
        public ShelterController(ISheltersService service, IMapper mapper, ILocationsService locationsService) : base(service, mapper)
        {
            _locationsService = locationsService;
        }
        public override async Task<ShelterEditVM> PrePopulateVMAsync()
        {
            var editVM = new ShelterEditVM
            {
                LocationList = (await _locationsService.GetAllActiveAsync()).Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()))
            };
            return editVM;
        }
        
    }

}
