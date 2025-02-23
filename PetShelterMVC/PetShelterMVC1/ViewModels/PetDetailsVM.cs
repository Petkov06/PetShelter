﻿using PetShelter.Data.Entities;
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
    public class PetDetailsVM : BaseVM
    {
        public PetDetailsVM() 
        {
            this.PetVaccines = new List<PetVaccineDetailsVM>();
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAdopted { get; set; }

        public bool IsEuthanized { get; set; }
        [DisplayName("Pet Type")]

        public int PetTypeId { get; set; }
        [DisplayName("Breed")]

        public int BreedId { get; set; }


        public int? AdopterId { get; set; }

        public int? GiverId { get; set; }


        public int? ShelterId { get; set; }


        public virtual List<PetVaccineDetailsVM> PetVaccines { get; set; }
    }
}
