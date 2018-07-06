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
            System.Threading.Thread.Sleep(1500);
        }
    }
}
