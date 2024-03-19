using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Entities
{
    public class PetVaccine : BaseEntity
    {
        public int PetId { get; set; }

        public virtual Pet Pet { get; set; }

        public int VaccineId { get; set; }

        public virtual Vaccine Vaccine { get; set; }
    }
}
