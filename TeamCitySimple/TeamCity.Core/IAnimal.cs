using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity.Core
{
    public interface IAnimal
    {
        string AnimalType { get; set; }
        string Name{ get; set; }
        string Talk();
    }
}
