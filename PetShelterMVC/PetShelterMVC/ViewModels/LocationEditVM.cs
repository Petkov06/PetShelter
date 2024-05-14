using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class LocationEditVM : BaseVM
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
   
    }
}
