using HWServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HWWebApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        private IHWService _hwService;

        public HelloWorldController(IHWService HwService)
        {
            
            _hwService = HwService;
        }
            
        public string Get()
        {
            return _hwService.SayHello();
        }
            
    }
}
