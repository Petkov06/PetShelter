using PetShelter.Data.Entities;
using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModels
{
    public class PetVaccineDetailsVM : BaseVM
    {
        public int PetId { get; set; }

        public PetDetailsVM Pet { get; set; }

        public int? VaccineId { get; set; }

        public VaccineDetailsVM Vaccine { get; set; }
    }
}
