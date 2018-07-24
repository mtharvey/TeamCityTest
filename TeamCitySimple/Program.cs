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
            service.GetAnimals().ToList().ForEach(animal => { Console.WriteLine($"There is a {animal.AnimalType} named {animal.Name}"); });

            //var peopleService = new TeamCityServices.PeopleService();
            //peopleService.GetPeople().ToList().ForEach(p => { Console.WriteLine($"There is a person named {p.FirstName} {p.LastName}"); });


            Console.Write("New version");

            Console.Write("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
