﻿using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class RoleDetailsVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public List<UserDetailsVM> Users { get; set; }
    }
}
