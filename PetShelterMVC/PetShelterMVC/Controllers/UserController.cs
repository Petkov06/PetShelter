using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using NuGet.Protocol.Core.Types;
using PetShelterMVC.ViewModels;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System.Threading.Tasks;
using PetShelter.Services;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class UserController : BaseCrudController<UserDto, IUserRepository, IUsersService, UserEditVM, UserDetailsVM>
    {
        public IRoleRepository _roleService { get; set; }
        public IBreedsService _breedsService { get; set; }
        public UserController(IUsersService service, IMapper mapper, IRoleRepository _roleService, IBreedsService _breedsService) : base(service, mapper)
        {
            this._roleService = _roleService;
            this._breedsService = _breedsService;
        }
        public override async Task<UserEditVM> PrePopulateVMAsync()
        {
            var editVM = new UserEditVM
            {
                RoleList = (await _roleService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString())),
                ShelterList = (await _breedsService.GetAllAsync()).Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()))
            };
            return editVM;
        }

    }
}
