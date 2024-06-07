using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelterMVC.ViewModels
{
    public class PetVaccineEditVM
    {
        [DisplayName("Pet Vacinnes")]
        [Required]
        public int PetId { get; set; }

        [Required]
        public int VaccineId { get; set; }

    }
}
