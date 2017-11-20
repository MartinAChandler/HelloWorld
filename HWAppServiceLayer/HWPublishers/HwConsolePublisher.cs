using HWAppInterfaces.HWPublishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAppServiceLayer.HWPublishers
{
    public class HwConsolePublisher : IHwPublisher
    {
        public void WriteHello(string HelloValue)
        {
            Console.WriteLine(HelloValue);
        }
    }
}
