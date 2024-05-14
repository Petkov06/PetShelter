using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class LoginVm : BaseVM
    {
        [Required]

        public string Username { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
