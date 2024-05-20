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

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class UserController : BaseCrudController<UserDto, IUserRepository, IUsersService, UserEditVM, UserDetailsVM>
    {
        public UserController(IUsersService service, IMapper mapper, IUsersService userService) : base(service, mapper)
        {
        }
       

    }
}
