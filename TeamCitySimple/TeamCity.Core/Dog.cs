using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity.Core
{
    public class Dog : Animal
    {
        public override string AnimalType
        {
            get
            {
                return "Dog";
            }
        }

        public override string Talk()
        {
            return "Woof";
        }
    }
}
