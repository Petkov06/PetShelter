using System.ComponentModel.DataAnnotations;

namespace PetShelterMVC.ViewModels
{
    public class PetVaccineEditVM
    {
        [Required]
        public int PetId { get; set; }

        [Required]
        public int VaccineId { get; set; }

    }
}
