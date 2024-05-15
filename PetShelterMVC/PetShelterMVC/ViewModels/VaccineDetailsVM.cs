using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class VaccineDetailsVM : BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual List<PetVaccineDetailsVM> PetVaccines { get; set; }
    }
}
