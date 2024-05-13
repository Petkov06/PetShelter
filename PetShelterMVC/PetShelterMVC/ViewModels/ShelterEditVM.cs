using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class ShelterEditVM : BaseVM
    {
        [Required]
        public int PetCapacity { get; set; }

        [Required]
        [DisplayName("Location")]
        public int LocationId { get; set; }
        public IEnumerable<SelectListItem> LocationList { get; set; }
    }
}
