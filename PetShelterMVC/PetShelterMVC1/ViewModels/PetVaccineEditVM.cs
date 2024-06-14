using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelterMVC.ViewModels
{
    public class PetVaccineEditVM
    {
        [DisplayName("Pet Vacinnes")]
        [Required]
        public int VaccineId { get; set; }



        [Required]
        public int PetId { get; set; }

       
        public IEnumerable<SelectListItem> PetList { get; set; }
        public IEnumerable<SelectListItem> VaccineList { get; set; }

    }
}
