using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamCity.Core;

namespace TeamCityServices
{
    public class AnimalService
    {
        public IEnumerable<IAnimal> GetAnimals()
        {
            var animals = new List<IAnimal>();
            animals.Add(new Cat { Name = "Shit Rock" });
            animals.Add(new Dog { Name = "Ellie" });
            animals.Add(new Monkey { Name = "Pistol Pete" });
            return animals;
        }
    }
}
