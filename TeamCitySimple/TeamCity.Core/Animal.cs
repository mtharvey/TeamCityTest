﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity.Core
{
    public abstract class Animal : IAnimal
    {
        public string Name{ get; set; }
        public abstract string AnimalType { get; }
        public abstract string Talk();
        
    }
}
