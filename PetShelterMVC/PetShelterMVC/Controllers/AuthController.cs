using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Services.ViewModels;
using PetShelter.Shared;
using PetShelter.Shared.Services.Contracts;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    public class AuthController:Controller
    {
        private readonly IUsersService usersService;
        private readonly IRolesService rolesService;
        private readonly IMapper mapper;

        public AuthController(IUsersService usersService, IRolesService rolesService, IMapper mapper)
        {
            this.usersService = usersService;
            this.rolesService = rolesService;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginVm model)
        {
            string loggedUsername = User.FindFirst(ClaimTypes.Name)?.Value;
            if(loggedUsername != null) 
            {
                return Forbid();
            }
            if(!await this.usersService.CanUserLoginAsync(model.Username, model.Password))
            {
                return BadRequest(Constants.InvalidCredentials);
            }
            await LoginUser(model.Username);
            return RedirectToAction(nameof(HomeController.Index),"Home");
        }
        private async Task LoginUser(string username)
        {
            var user = await this.usersService.GetByUsernameAsync(username);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.Name),
            };

                
        }
    }
}
