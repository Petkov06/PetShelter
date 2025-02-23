﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class BreedEditVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public BreedSize Size { get; set; }

        public IEnumerable<SelectListItem> BreedList { get; set; }

    }
}
