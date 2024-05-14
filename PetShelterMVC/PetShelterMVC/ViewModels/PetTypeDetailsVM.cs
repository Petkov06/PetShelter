using PetShelter.Shared.Dtos;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class PetTypeDetailsVM : BaseVM
    {
        public PetTypeDetailsVM()
        {
            this.Pets = new List<PetTypeDetailsVM>();
        }

        public string Name { get; set; }

        public List<PetTypeDetailsVM> Pets { get; set; }
    }
}
