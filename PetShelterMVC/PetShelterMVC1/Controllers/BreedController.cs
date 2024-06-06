﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelterMVC.ViewModels;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes =CookieAuthenticationDefaults.AuthenticationScheme,Roles="Admin, Employee, User ")]
    public class BreedController:BaseCrudController<BreedDto,IBreedRepository,IBreedsService,BreedEditVM,BreedDetailsVM>
    {
        public BreedController(IBreedsService service, IMapper mapper): base(service, mapper)
        {

        }
    }
}
