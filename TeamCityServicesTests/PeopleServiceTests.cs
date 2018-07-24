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
    public class PeopleServiceTests
    {
        [TestMethod()]
        public void GetPeopleTest()
        {
            PeopleService service = new PeopleService();
            var peeps = service.GetPeople();
            Assert.AreEqual(1, peeps.Count());
        }
    }
}