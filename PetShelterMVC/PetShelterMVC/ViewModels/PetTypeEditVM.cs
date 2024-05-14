using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class PetTypeEditVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

       
    }
}
