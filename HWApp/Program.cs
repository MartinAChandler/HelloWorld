using HWAppInterfaces;
using HWAppInterfaces.HWPublishers;
using HWAppInterfaces.HwRepositories;
using HWAppServiceLayer.HWPublishers;
using HWAppServiceLayer.HwRepositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string APPCFG_PUBLISHER_TYPE = "publisherType";
            const string APPCFG_WEBAPI_URI = "webApiUri";
            const string APPCFG_WEBAPI_GETCMD = "webApiGetHwCmd";

            string publisherType = ConfigurationManager.AppSettings[APPCFG_PUBLISHER_TYPE];
            string webApiUri = ConfigurationManager.AppSettings[APPCFG_WEBAPI_URI];
            string webApiGetHwCmd = ConfigurationManager.AppSettings[APPCFG_WEBAPI_GETCMD];




            IHwRepository apiRepo = new HwWebApiRepo(webApiUri, webApiGetHwCmd);




            IHwPublisher consolePub = HwPublisherFactory.CreateHwPublisher(publisherType);


            HelloWorldProcessor proc = new HelloWorldProcessor(apiRepo, consolePub);

            proc.PublishGreeting();

            Console.WriteLine("Press Enter to End Program.");
            Console.ReadLine();
        }
    }
}
