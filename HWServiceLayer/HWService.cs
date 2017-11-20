using HWServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWServiceLayer
{
    public class HWService : IHWService
    {
        public string SayHello()
        {
            return "Hello World";
        }
    }
}
