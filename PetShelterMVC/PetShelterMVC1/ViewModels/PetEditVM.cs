﻿using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class PetEditVM : BaseVM
    {
        [DisplayName("Pets")]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAdopted { get; set; }

        public bool IsEuthanized { get; set; }

        [DisplayName("Pet Type")]
        [Required]
        public int PetTypeId { get; set; }

        [DisplayName("Breed")]
        [Required]
        public int BreedId { get; set; }
       
        [Required]

        public int? AdopterId { get; set; }
        [Required]

        public int? GiverId { get; set; }

        [Required]

        public int? ShelterId { get; set; }

        public IEnumerable<SelectListItem> PetTypeList { get; set; }

        public IEnumerable<SelectListItem> BreedList { get; set; }

        public IEnumerable<SelectListItem> UserList { get; set; }



    }
}
