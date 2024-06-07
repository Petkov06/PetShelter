using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class BreedDetailsVM : BaseVM
    {
        [DisplayName("Breed")]
        public string  Name { get; set; }
        public BreedSize Size { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}
