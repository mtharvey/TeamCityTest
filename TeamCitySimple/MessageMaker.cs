using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySimple
{
    public class MessageMaker
    {
        public static string GetMessage()
        {
            var currentSecond = DateTime.Now.Second;
            if (currentSecond < 10)
                return "Hello";
            else if (currentSecond < 20)
                return "Howdy";
            else if (currentSecond < 30)
                return "What's up?";
            else if (currentSecond < 40)
                return "Hey, dipshit!";
            else if (currentSecond < 50)
                return "Hello world.";
            else if (currentSecond < 55)
                return "Stank";
            else
                return "Shibby";
        }
    }

}
