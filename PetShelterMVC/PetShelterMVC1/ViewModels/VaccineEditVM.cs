using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class VaccineEditVM : BaseVM
    {
        [DisplayName("Vaccines")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public IEnumerable<SelectListItem> VaccineList { get; set; }


    }
}
