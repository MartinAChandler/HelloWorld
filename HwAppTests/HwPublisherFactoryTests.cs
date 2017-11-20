using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWAppServiceLayer.HWPublishers;
using HWAppInterfaces.HWPublishers;

namespace HWAppTests
{
    [TestClass]
    public class HwPublisherFactoryTests
    {
        [TestMethod]
        public void PublisherTypeConsole()
        {
            string publisherType = "console";

            IHwPublisher publisher = HwPublisherFactory.CreateHwPublisher(publisherType);

            Assert.IsInstanceOfType(publisher, typeof(HwConsolePublisher));
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void PublisherTypeDBNotImplemented()
        {
            string publisherType = "database";

            IHwPublisher publisher = HwPublisherFactory.CreateHwPublisher(publisherType);

            Assert.IsInstanceOfType(publisher, typeof(HwConsolePublisher));
        }


    }
}
