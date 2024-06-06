using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelterMVC.ViewModels
{
    public class AdoptPetEditVM
    {
        [DisplayName("Pet")]
        public int PetId {  get; set; }
        public IEnumerable<SelectListItem> PetList { get; set; }
    }
}
