using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class PetVaccineDetailsVM : BaseVM
    {
        [Required]
        public int PetId { get; set; }

        [Required]
        public int VaccineId { get; set; }
    }
}
