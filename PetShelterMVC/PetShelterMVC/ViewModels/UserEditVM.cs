using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class UserEditVM : BaseVM
    {
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
        public int? ShelterId { get; set; }

    }
}
