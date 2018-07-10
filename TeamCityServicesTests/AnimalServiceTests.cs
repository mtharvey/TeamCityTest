using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityServices.Tests
{
    [TestClass()]
    public class AnimalServiceTests
    {
        [TestMethod()]
        public void GetAnimalsTest()
        {
            var service = new AnimalService();
            var animals = service.GetAnimals();
            Assert.AreEqual(4, animals.Count(), "GetAnimals() returned and unexpected number of animals");
        }

        [TestMethod()]
        public void GetDogsTest()
        {
            var service = new AnimalService();
            var dogs = service.GetDogs();
            Assert.AreEqual(2, dogs.Count(), "GetDogs() returned and unexpected number of dogs");
        }
    }
}