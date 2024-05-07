using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace PetShelter.Data.Entities
{
    public class PetType : BaseEntity
    {
        public PetType()
        {
            this.Pets = new List<Pet>();
        }

        public string Name { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
