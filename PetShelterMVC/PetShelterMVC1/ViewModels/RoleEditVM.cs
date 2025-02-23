﻿using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class RoleEditVM : BaseVM
    {
        [DisplayName("Roles")]
        [Required]
        public string Name { get; set; }
    }
}
