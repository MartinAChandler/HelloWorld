using HWAppInterfaces.HWPublishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAppServiceLayer.HWPublishers
{
    public class HwPublisherFactory
    {


        public const string PUBTYPE_CONSOLE = "console";
        public static IHwPublisher CreateHwPublisher(string publisherType)
        {
            IHwPublisher publisher;

            switch(publisherType.ToLower())
            {
                case PUBTYPE_CONSOLE:
                    publisher = new HwConsolePublisher();
                    break;
                default:
                    throw new NotImplementedException(string.Format("The Hello Wolrd publisher {0} is not implemented", publisherType));
                
            }

            return publisher;
        }
    }
}
