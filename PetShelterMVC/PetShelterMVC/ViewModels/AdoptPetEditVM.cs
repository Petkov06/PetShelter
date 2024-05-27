using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PetShelterMVC.ViewModels
{
    public class AdoptPetEditVM
    {
        public int PetId {  get; set; }
        public IEnumerable<SelectListItem> PetList { get; set; }
    }
}
