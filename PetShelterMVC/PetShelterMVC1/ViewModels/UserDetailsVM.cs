﻿using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class UserDetailsVM : BaseVM
    {
        public UserDetailsVM()
        {
            this.AdoptedPets = new List<PetDetailsVM>();
            this.GivenPets = new List<PetDetailsVM>();

        }

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

        [Required]
        public  RoleDetailsVM Role { get; set; }

        [Required]
        public int? ShelterId { get; set; }

        [Required]
        public ShelterDetailsVM Shelter { get; set; }
        [Required]
        public List<PetDetailsVM> AdoptedPets { get; set; }

        [Required]
        public List<PetDetailsVM> GivenPets { get; set; }
        
       
       
    }
}
