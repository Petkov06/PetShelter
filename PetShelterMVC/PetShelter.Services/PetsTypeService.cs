﻿using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    
        [AutoBind]
        public class PetsTypeService : BaseCrudService<PetTypeDto, IPetTypeRepository>, IPetTypeService
    {
            public PetsTypeService(IPetTypeRepository repository) : base(repository)
            {

            }
        }
    
}
