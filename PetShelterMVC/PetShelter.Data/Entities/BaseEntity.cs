﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Entities
{
    public abstract class BaseEntity :IBaseEntity
    {
        public int Id { get; set; }
    }
}
