namespace PetShelter.Shared.Dtos
{
    public class PetVaccineDto : BaseModel
    {
        public PetVaccineDto(int petId, int vaccineId)
        {
            this.PetId = petId;
            this.VaccineId = vaccineId;
        }
        public int? PetId { get; set; }

        public PetDto Pet { get; set; }

        public int? VaccineId { get; set; }

        public VaccineDto Vaccine { get; set; }
    }
}
