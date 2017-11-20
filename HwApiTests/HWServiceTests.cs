using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWServiceLayer;

namespace HWServiceTests
{
    [TestClass]
    public class HWServiceTests
    {
        [TestMethod]
        public void SaysHelloWorld()
        {
            const string HELLO_WORLD = "Hello World";
            HWService service = new HWService();
            string result = service.SayHello();

            Assert.AreEqual(HELLO_WORLD, result);
        }
    }
}
