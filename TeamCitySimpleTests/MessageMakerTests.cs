using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCitySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySimple.Tests
{
    [TestClass()]
    public class MessageMakerTests
    {
        [TestMethod()]
        public void GetMessageTest()
        {
            var message = MessageMaker.GetMessage();
            Assert.AreEqual(false, string.IsNullOrWhiteSpace(message));
        }

    }
}