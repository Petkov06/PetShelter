﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class UserEditVM : BaseVM
    {
        [DisplayName("Users")]
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int? RoleId { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }

        [Required]
        public int? ShelterId { get; set; }
        public IEnumerable<SelectListItem> ShelterList { get; set; }
    }
}
