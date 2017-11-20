using HWAppInterfaces;
using HWAppInterfaces.HWPublishers;
using HWAppInterfaces.HwRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsole
{
    public class HelloWorldProcessor
    {
        private IHwRepository _hwRepo;
        private IHwPublisher _hwPub;

        public HelloWorldProcessor(IHwRepository HwRepo, IHwPublisher HwPublisher)
        {
            _hwRepo = HwRepo;
            _hwPub = HwPublisher;

        }

        public void PublishGreeting()
        {
            try
            {
                string greetingText = _hwRepo.GetHelloWorld();

                _hwPub.WriteHello(greetingText);
            }
            catch (Exception ex)
            {

                throw ex;
            }
    

        }
            
            
            
    }
}
