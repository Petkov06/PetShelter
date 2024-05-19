using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelterMVC.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter.Services;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class PetController : BaseCrudController<PetDto, IPetRepository, IPetsService, PetEditVM, PetDetailsVM>
    {
        public IPetsService _petService { get; set; }
        public PetController(IPetsService service, IMapper mapper) : base(service, mapper)
        {

        }

        //public override async Task<PetEditVM> PrePopulateVMAsync()
        //{
        //    var editVM = new PetEditVM
        //    {
        //        PetTypeList = await _petService.GetAll()
        //    };
        //    return editVM;
        //}
    }
}
