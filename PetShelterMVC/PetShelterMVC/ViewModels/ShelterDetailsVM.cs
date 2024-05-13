using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class ShelterDetailsVM : BaseVM
    {
        public  ShelterDetailsVM() 
        { 
            this.Pets = new List<PetDetailsVM>();
            this.Employees = new List<UserDetailsVM>();
        }
        public int PetCapacity { get; set; }
        public int LocationId { get; set; }
        public List<UserDetailsVM> Employees { get; set; }
        public List<PetDetailsVM> Pets { get; set; }
    }
}
