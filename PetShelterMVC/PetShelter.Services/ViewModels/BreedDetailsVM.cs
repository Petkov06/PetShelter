﻿using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.ViewModels
{
    public class BreedDetailsVM : BaseVM
    {
        public string  Name { get; set; }
        public BreedSize Size { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}
