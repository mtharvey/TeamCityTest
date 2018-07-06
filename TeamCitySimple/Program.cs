using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySimple
{
    class Program
    {
        static void Main(string[] args)
        {
            User harvey = new User { Username = "@realHarvey", FirstName = "Mike", LastName = "Harvey" };
            Console.WriteLine(MessageMaker.GetMessage());
            Console.WriteLine("---------------------");
            Console.WriteLine();

            var service = new TeamCityServices.AnimalService();
            service.GetAnimals().ToList().ForEach(animal => { Console.WriteLine($"There is a {animal.AnimalType} name {animal.Name}"); });


            System.Threading.Thread.Sleep(2000);
        }
    }
}
